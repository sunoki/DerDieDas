using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class wordList : MonoBehaviour
{

    List<words> lstWords = new List<words>();

    private int intNumTranslations;
    private string[] strLangOfTranslations;

    public int IntNumTranslations { get => intNumTranslations; set => intNumTranslations = value; }
    public string[] StrLangOfTranslations { get => strLangOfTranslations; set => strLangOfTranslations = value; }

    // Start is called before the first frame update
    void Awake()
    {
        using (var reader = new StreamReader("words.csv"))
        {
            int intLineNumber = 0;
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(',');
                //If it is the first line, let's get the languages that the words are translated to
                
                if (intLineNumber == 0)
                {
                    intNumTranslations = values.Length - 2;
                    strLangOfTranslations = new string[intNumTranslations];
                    for (int i = 0; i < intNumTranslations; i++)
                    {
                        strLangOfTranslations[i] = values[i+2];
                        Debug.Log("inclui idioma " + values[i+2]);
                    }
                } else
                //If not, then lets get the words themselves
                {
                    string[] strTranslations = new string[intNumTranslations];
                    for (int i = 0; i < intNumTranslations; i++)
                    {
                        strTranslations[i] = values[i+2];
                    }
                    lstWords.Add(new words(values[0], values[1], strTranslations));
                }
                intLineNumber++;

            }
        }
    }

    //Return one of the words from the list randomly
    public words getRandomWord()
    {
        int rnd = Random.Range(0, lstWords.Count);
        return lstWords[rnd];
        
    }

}

//Simple struct to handle the word with its article
public struct words
{
    private string strArtikel;
    private string strWord;
    private string [] arrTranslation;
    
    public words(string artikel, string word, string [] translation)
    {
        this.strArtikel = artikel;
        this.strWord = word;
        this.arrTranslation = translation;
    }

    public string artikelGetSet { get => strArtikel; set => strArtikel = value; }
    public string wordGetSet { get => strWord; set => strWord = value; }
    public string[] ArrTranslation { get => arrTranslation; set => arrTranslation = value; }
}


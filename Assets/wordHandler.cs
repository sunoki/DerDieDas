using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class wordHandler : MonoBehaviour
{
    //Scripts
    private timeHandler scrTime;
    private correctWordHandler scrCorrectWord;
    private wordList scrWords;
    private words stuCurrentWord;

    //UI Texts
    public Text txtWord;
    public Text txtWordTranslation;

    //UI Audios
    public AudioSource audCorrect;
    public AudioSource audIncorrect;

    //Define amounts to increase and decrease Time
    private int intBonusSeconds = 2;
    private int intPenaltySeconds = 5;

    //Translation Language
    public const int intEn = 0;
    public const int intPt = 1;
    public const int intDefault = 2;
    private int intLanguage;
    // Start is called before the first frame update
    void Start()
    {
        //Load other classes
        scrTime = this.GetComponent<timeHandler>();
        scrWords = this.GetComponent<wordList>();
        scrCorrectWord = this.GetComponent<correctWordHandler>();

        intLanguage = PlayerPrefs.GetInt("language");

        //Choose the first word
        stuCurrentWord = scrWords.getRandomWord();
        txtWord.text = stuCurrentWord.wordGetSet;
        //Default is no translation
        if (intLanguage == intDefault)
        {
            txtWordTranslation.text = "";
        } else
        {
            txtWordTranslation.text = stuCurrentWord.ArrTranslation[intLanguage];
        }
        
    }


 
    //Handle click on Buttons
    public void onClick(string strArtikel)
    {
        //check if the article clicked is correct
        if (stuCurrentWord.artikelGetSet == strArtikel)
        {
            audCorrect.Play(0);
            scrCorrectWord.increaseCorrectWord();
            scrTime.increaseTime(intBonusSeconds);
        }
        else
        {
            audIncorrect.Play(0);
            scrCorrectWord.increaseIncorrectWord();
            scrTime.decreaseTime(intPenaltySeconds);
        }

        //Select next word
        stuCurrentWord = scrWords.getRandomWord();
        txtWord.text = stuCurrentWord.wordGetSet;
        //Default is no translation
        if (intLanguage == intDefault)
        {
            txtWordTranslation.text = "";
        }
        else
        {
            txtWordTranslation.text = stuCurrentWord.ArrTranslation[intLanguage];
        }
    }
}

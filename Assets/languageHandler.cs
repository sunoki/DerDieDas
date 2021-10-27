using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class languageHandler : MonoBehaviour
{
    private int intLanguage;
    private wordList scrWords;

    public Dropdown dropLanguages;


    // Start is called before the first frame update
    void Start()
    {
        scrWords = this.GetComponent<wordList>();

        for (int i = 0; i < scrWords.IntNumTranslations; i++)
        {
            dropLanguages.options.Add(new Dropdown.OptionData(scrWords.StrLangOfTranslations[i]));
            Debug.Log(scrWords.StrLangOfTranslations[i]);
        }
        dropLanguages.options.Add(new Dropdown.OptionData("Keine"));

        intLanguage = PlayerPrefs.GetInt("language");
        dropLanguages.value = intLanguage;

    }

    public void updateLanguage()
    {
        PlayerPrefs.SetInt("language", dropLanguages.value);
    }
}

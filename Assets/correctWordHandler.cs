using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class correctWordHandler : MonoBehaviour
{
    //UI Texts
    public Text txtCorrectWord;
    public Text txtIncorrectWord;

    private int intCorrectWord;
    private int intIncorrectWord;

    public int IntCorrectWord { get => intCorrectWord; set => intCorrectWord = value; }
    public int IntIncorrectWord { get => intIncorrectWord; set => intIncorrectWord = value; }

    // Start is called before the first frame update
    void Start()
    {
        //Start text and variables with 0
        intCorrectWord = 0;
        txtCorrectWord.text = "Richtige wörter: 0";

        intIncorrectWord = 0;
        txtIncorrectWord.text = "Falsche wörter: 0";
    }

    //Counter of correct words, increased one by one
    public void increaseCorrectWord()
    {
        intCorrectWord++;
        txtCorrectWord.text = "Richtige wörter: " + intCorrectWord;

    }

    //Counter of incorrect words, increased one by one
    public void increaseIncorrectWord()
    {
        intIncorrectWord++;
        txtIncorrectWord.text = "Falsche wörter: " + intIncorrectWord;

    }
}

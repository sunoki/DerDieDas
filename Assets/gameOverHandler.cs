using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameOverHandler : MonoBehaviour
{
    //Objects with the on game and after game over objects
    public GameObject objGame;
    public GameObject objGameOver;
    
    //UI
    public Text txtGameOver;

    //Scripts
    private correctWordHandler scrCorrectWord;
    private recordHandler scrRecord;

    private void Start()
    {
        scrCorrectWord = this.GetComponent<correctWordHandler>();
        scrRecord = this.GetComponent<recordHandler>();
    }

    public void gameOver()
    {
        txtGameOver.text = "Das Spiel ist aus! Sie hatten " + scrCorrectWord.IntCorrectWord + " Antworten richtig und " + scrCorrectWord.IntIncorrectWord + " Antworten falsch.";

        //if we have a new record, let´s update it
        if (scrRecord.checkRecord(scrCorrectWord.IntCorrectWord))
            scrRecord.updateRecord(scrCorrectWord.IntCorrectWord);

        //Changing the available objects on Screen
        objGame.SetActive(false);
        objGameOver.SetActive(true);
    }
}

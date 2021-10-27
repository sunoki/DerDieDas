using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timeHandler : MonoBehaviour
{   
    //Scripts
    private musicHandler scrMusic;
    private gameOverHandler scrGameOver;

    //UI
    public Text txtTime;

    //Public variables, set on Unity
    public int intInitialTime;
    public float flGameOver;
    public float flMusicChanges;

    private float flTimer;

    // Start is called before the first frame update
    void Start()
    {
        flTimer = intInitialTime;
        txtTime.text = "Zeit: " + flTimer;
        scrGameOver = this.GetComponent<gameOverHandler>();
        scrMusic = this.GetComponent<musicHandler>();
        
    }

    // Update is called once per frame
    void Update()
    {

        // seconds in float
        flTimer -= Time.deltaTime;

        txtTime.text = "Zeit: " + flTimer.ToString("0.0");

        if (flTimer <= flMusicChanges)
            scrMusic.accelerateBackground();

        if (flTimer >= flMusicChanges)
            scrMusic.slowDownBackground();

        if (flTimer <= flGameOver)
        {
            scrGameOver.gameOver();
        }

    }

    //to be called anytime, we need to give more time to player. For example, when an answer is correct
    public void increaseTime(int intSeconds)
    {
        this.flTimer += intSeconds;
    }

    //to be called anytime, we need to give more time to player. For example, when an answer is not correct
    public void decreaseTime(int intSeconds)
    {
        this.flTimer -= intSeconds;
        if (this.flTimer < 0)
            this.flTimer = 0;
    }
}

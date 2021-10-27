using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameStartHandler : MonoBehaviour
{
    //Objects with the on game and after game over objects
    public GameObject objGame;
    public GameObject objGameOver;

    // Start is called before the first frame update
    void Start()
    {
        objGame.SetActive(true);
        objGameOver.SetActive(false);
    }

}

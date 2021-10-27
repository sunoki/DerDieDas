using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musicHandler : MonoBehaviour
{
    //UI
    public AudioSource audBackgroundSound;

    public void accelerateBackground()
    {
        audBackgroundSound.pitch = 2;
    }

    public void slowDownBackground()
    {
        audBackgroundSound.pitch = 1;
    }
}

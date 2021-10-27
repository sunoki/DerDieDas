using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class restartHandler : MonoBehaviour
{
    private string strMainMenuName = "mainMenu";
    // Start is called before the first frame update
    public void onClick()
    {
        Scene sceMainScene = SceneManager.GetActiveScene();
        //SceneManager.UnloadSceneAsync(sceMainScene.name);
        SceneManager.LoadScene(strMainMenuName);
    }
}

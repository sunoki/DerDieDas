using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class buttonHandler : MonoBehaviour
{
    private string strMainSceneName = "mainGame";
    private languageHandler scrLanguage;
    public GameObject goCredits;
    public GameObject goMenu;
    public GameObject goOptions;
    public GameObject goHowTo;
    
    public void Start()
    {
        scrLanguage = this.GetComponent<languageHandler>();
    }

    public void onClickStart()
    {
        Scene sceMenuScene = SceneManager.GetActiveScene();
        //SceneManager.UnloadSceneAsync(sceMenuScene.name);
        SceneManager.LoadScene(strMainSceneName);
    }

    public void onClickCredits()
    {
        goMenu.SetActive(false);
        goCredits.SetActive(true);
    }
    
    public void onClickOptions()
    {
        goMenu.SetActive(false);
        goOptions.SetActive(true);
    }

    public void onClickHowTo()
    {
        goMenu.SetActive(false);
        goHowTo.SetActive(true);
    }

    public void onClickBack(string strSubMenu)
    {
        if (strSubMenu == "Options")
        {
            goOptions.SetActive(false);
            scrLanguage.updateLanguage();
        }

        if (strSubMenu == "Credits")
            goCredits.SetActive(false);

        if (strSubMenu == "HowTo")
            goHowTo.SetActive(false);

        goMenu.SetActive(true);
    }

}

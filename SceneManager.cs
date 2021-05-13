using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SceneManager : MonoBehaviour
{
    public GameObject whoIsYoyoButton, backButton, menuScreen, yoyoScreen, highScoreScreen;

    public void GameScene()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("GameScene");
    }
    public void MainMenuScene()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("MainMenuScene");
    }
    public void WhoIsYoyoScreen()
    {
        menuScreen.SetActive(false);
        yoyoScreen.SetActive(true);
    }
    public void HighScoreScreen()
    {
        menuScreen.SetActive(false);
        highScoreScreen.SetActive(true);
    }
    public void MenuScreen()
    {
        yoyoScreen.SetActive(false);
        highScoreScreen.SetActive(false);
        menuScreen.SetActive(true);
    }

}

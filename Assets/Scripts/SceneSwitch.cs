using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitch : MonoBehaviour {

    public void StartGame()
    {
        SceneManager.LoadScene("GameplayScreen");
    }
    public void TitleScreen()
    {
        SceneManager.LoadScene("TitleScene");
    }
    public void ExitGame()
    {
        Application.Quit();
    }
}

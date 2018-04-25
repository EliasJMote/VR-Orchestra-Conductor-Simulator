using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using UnityEngine.UI;

[System.Serializable]
public class Controller : MonoBehaviour {
    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
    public void TitleScreen()
    {
        song = "Theme";
        SceneManager.LoadScene("Title Screen");
    }
	public void PlayGame()
    {
        Debug.Log("Button: " + button.name);
        if( button.name == "Level1")
        {
            song = "Level2";
        }
        else if(button.name == "Level2")
        {
            song = "Level3";
        }
        else
        {
            song = "Theme";
        }
        
        SceneManager.LoadScene("GameStart");
    }
    public void LevelSelect()
    {
        song = "Theme";
        SceneManager.LoadScene("LevelSelect");
    }
    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
    public void SetVolume(float v)
    {

    }
    static public string song;
    public Button button;
}

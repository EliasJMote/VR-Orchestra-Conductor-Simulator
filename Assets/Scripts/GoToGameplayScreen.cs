using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToGameplayScreen : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Button btn = GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
        //SceneManager.LoadScene("GameplayScreen");
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void TaskOnClick()
    {
        SceneManager.LoadScene("GameplayScreen", LoadSceneMode.Single);
    }
}

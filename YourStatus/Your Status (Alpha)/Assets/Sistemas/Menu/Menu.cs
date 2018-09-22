using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Play()
    {
        if (PlayerPrefs.HasKey("intro"))
        {
            SceneManager.LoadScene("mapa");

        } else
        {
            SceneManager.LoadScene("Intro");
            PlayerPrefs.SetInt("intro", 0);
        }
        
    }

    public void Exit()
    {
        Application.Quit();
    }


    public void Reset()
    {
        PlayerPrefs.DeleteAll();
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ButtonFunction : MonoBehaviour {

    public string nivel;
    public string fim;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void TryAgain()
    {
        Application.LoadLevel(nivel);
    }

    public void End()
    {
        Application.LoadLevel(fim);
    }
}

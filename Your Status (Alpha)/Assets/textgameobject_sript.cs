﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class textgameobject_sript : MonoBehaviour {

    public Text textArea;
    public string[] strings;
    public float speed = 0.03f;

    int stringIndex = 0;
    int characterIndex = 0;

	// Use this for initialization
	void Start () {
		
        StartCoroutine(DisplayTimer());

	}

    IEnumerator DisplayTimer()
    {
        while (1 == 1)
        {
            yield return new WaitForSeconds(speed);
            if (characterIndex > strings[stringIndex].Length)
            {
                continue;
            }

            textArea.text = strings[stringIndex].Substring(0, characterIndex);
            characterIndex++;
        }
    }
	
	// Update is called once per frame
	void Update () {

        if (stringIndex == 11)
        {
            skip();
        }
        try
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {


                if (characterIndex < (strings[stringIndex].Length-1))
                {
                    characterIndex = strings[stringIndex].Length;
                }
                else
                {
                    stringIndex++;
                    characterIndex = 0;
                }

            }

        }
        catch (System.IndexOutOfRangeException ex)
        {
            skip();
    
        }


}

    public void skip()
    {
        SceneManager.LoadScene("mapa");
    }
}

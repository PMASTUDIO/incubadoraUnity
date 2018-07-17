using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Roubar : MonoBehaviour {

    public bool canwin = false;
    public GameObject Goal;
    public GameObject VictorySong;
    public GameObject AlertSong;
    public GameObject VisaoFrente;
    public GameObject VisaoLado;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
	}

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == "Goal")
        {
            if (Input.GetKeyDown(KeyCode.P))
            {
                GameObject.Find("Guarda").GetComponent<ScriptGuarda>().EmGuarda();
                Goal.SetActive(false);
                canwin = true;
            }
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Finish")
        {
            if (canwin == true)
            {
                VictorySong.SetActive(true);
                AlertSong.SetActive(false);
            }
        }
    }

    public void Perdeste()
    {
        canwin = false;
    }
}

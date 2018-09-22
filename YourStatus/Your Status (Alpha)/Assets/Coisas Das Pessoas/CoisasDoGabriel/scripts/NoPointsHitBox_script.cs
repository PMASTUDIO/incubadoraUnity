using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoPointsHitBox_script : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void play()
	{
		AudioSource lol = gameObject.GetComponent<AudioSource> ();
		lol.Play ();
	}
}

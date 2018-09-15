using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow_script : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Animator ar = gameObject.GetComponent<Animator>();

        ar.Play("colorfularrow");
    }
	
	// Update is called once per frame
	void Update () {
 
	}
}

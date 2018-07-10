using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followPlayer : MonoBehaviour {

    public GameObject player;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //Set the camera position to be equals to the player position;
        this.transform.position = new Vector3(player.transform.position.x, player.transform.position.y, this.transform.position.z);
	}
}

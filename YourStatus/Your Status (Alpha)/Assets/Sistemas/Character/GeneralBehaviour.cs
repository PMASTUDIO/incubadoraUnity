using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneralBehaviour : MonoBehaviour {

    //Variable that gets a transform for spawn point
    public Transform spawnPoint;

	// Use this for initialization
	void Start () {
        //If transform spawn point has tag SpawnPoint than
        if (spawnPoint.CompareTag("SpawnPoint"))
        {
            //The player position will be equal to the spawn point position

            this.transform.position = spawnPoint.position;
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

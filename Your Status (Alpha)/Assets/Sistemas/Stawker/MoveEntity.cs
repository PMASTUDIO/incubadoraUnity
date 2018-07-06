using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEntity : MonoBehaviour {
    public float speed;
    private int screenWidth;
    private int screenHeight;
    private Vector3 dir;
    // Use this for initialization
    void Start () {
        screenWidth = Screen.width;
        screenHeight = Screen.height;        
    }
	
	// Update is called once per frame
	void Update () {
        if (transform.position.x >= 8)
        {
            dir = new Vector3(-speed, 0, 0);
        }
        else if (this.transform.position.x <= -8)
        {
            dir = new Vector3(speed, 0, 0);
        }

        transform.position += dir;
    }
}

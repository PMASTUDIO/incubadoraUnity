using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jogadorminigamevenda : MonoBehaviour {

    int angle = 45;

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        rotation();
    }


    void rotation()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.Rotate(new Vector3(0, 0, (int)(transform.rotation.z) - angle));
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.Rotate(new Vector3(0, 0, (int)(transform.rotation.z) + angle));
        }
    }


}

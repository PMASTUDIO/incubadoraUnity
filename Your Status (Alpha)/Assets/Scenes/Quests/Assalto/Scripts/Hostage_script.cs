using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hostage_script : MonoBehaviour {

    public bool startrunning = false;
    public Transform crowd;
    public float speed = 15;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Rigidbody2D rb = gameObject.GetComponent<Rigidbody2D>();

        if (startrunning == true)
        {
            rb.velocity = new Vector2(speed, 0);
        }

    }

    public void Run()
    {
        startrunning = true;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Rigidbody2D rb = gameObject.GetComponent<Rigidbody2D>();

        if (collision.gameObject.tag == "Exit")
        {
            startrunning = false;
            rb.velocity = new Vector2(0, 0);
            transform.position = crowd.position;
            GameObject.Find("MainCharacter").GetComponent<PlayerAssalto_script>().losetime();
        }
    }
}

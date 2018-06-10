using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Andar : MonoBehaviour {
	public Rigidbody2D self;
	public float velocidade;
    private float xscale;
    private float yscale;
	// Use this for initialization
	void Start () {
		self = GetComponent<Rigidbody2D>();
        xscale = transform.localScale.x;
        yscale = transform.localScale.y;
    }
	
	// Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move()
    {
        if (Input.GetAxis("Vertical") > 0)
        {
            self.transform.position += new Vector3(0, velocidade / 100, 0) * Time.deltaTime;
            gameObject.GetComponent<Animator>().Play("WalkingBack");
        }
        else if (Input.GetAxis("Vertical") < 0)
        {
            self.transform.position -= new Vector3(0, velocidade / 100, 0) * Time.deltaTime;
            gameObject.GetComponent<Animator>().Play("WalkingFront");
        }

        else if (Input.GetAxis("Horizontal") > 0)
        {
            self.transform.localScale = new Vector3(xscale, yscale, 0);
            self.transform.position += new Vector3(velocidade / 100, 0, 0) * Time.deltaTime;
            gameObject.GetComponent<Animator>().Play("WalkingSide");
        }
        else if (Input.GetAxis("Horizontal") < 0)
        {
            self.transform.localScale = new Vector3(-xscale, yscale, 0);
            self.transform.position -= new Vector3(velocidade / 100, 0, 0) * Time.deltaTime;
            gameObject.GetComponent<Animator>().Play("WalkingSide");
        }

        else
        {
            gameObject.GetComponent<Animator>().Play("Idle");
        }
    }
}

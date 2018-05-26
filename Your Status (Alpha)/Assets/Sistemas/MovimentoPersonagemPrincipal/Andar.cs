using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Andar : MonoBehaviour {
	public Rigidbody2D self;
	public float velocidade;
	// Use this for initialization
	void Start () {
		self = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		Forward ();
	}

	void Forward(){
		if(Input.GetAxis("Vertical") > 0){
			self.transform.position += new Vector3 (0, velocidade / 100, 0) * Time.deltaTime;
		}
		else if(Input.GetAxis("Vertical") < 0){
			self.transform.position -= new Vector3 (0, velocidade / 100, 0) * Time.deltaTime;
		}
	}
}

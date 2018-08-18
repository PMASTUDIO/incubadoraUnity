using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ballscript : MonoBehaviour {

    public AudioClip okay;
    public float timer = 10;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        timer -= Time.deltaTime;

        if (timer <= 0)
        {
            Destroy(gameObject);
        }
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            GameObject.Find("playerminigamevenda").GetComponent<jogadorminigamevenda>().playokay();
            Destroy(gameObject);
        }

        if (collision.tag == "Miss")
        {
            Destroy(gameObject);
        }
    }

}

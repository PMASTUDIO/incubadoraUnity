using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cashier_script : MonoBehaviour {

    public int health = 1;
    public bool startcountdown = false;
    public bool tplayer = false;
    public float searchtimer = 5;
    public bool permission = true;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (startcountdown == true)
        {
            searchtimer -= Time.deltaTime;
        }


        if (searchtimer <= 0 || health == 0)
        {
            if (permission == true)
            {
                GameObject.Find("MainCharacter").GetComponent<PlayerAssalto_script>().earnmoneycashier();
                if (health == 0)
                {
                    health = -1;
                }
            }

            startcountdown = false;
            searchtimer = 5;
            permission = false;

        }


        if (tplayer == true && Input.GetKeyDown(KeyCode.Q))
        {
            startcountdown = true;          
        }

        if (Input.GetKeyUp(KeyCode.Q))
        {
            startcountdown = false;
            searchtimer = 5;           
        }

	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            tplayer = true;
        }

        if (collision.gameObject.tag == "Bullet")
        {
            health--;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            tplayer = false;
        }
    }

}

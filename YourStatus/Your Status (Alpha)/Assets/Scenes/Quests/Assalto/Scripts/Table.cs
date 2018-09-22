using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Table : MonoBehaviour {

    public int health = 2;
    public bool startcountdown = false;
    public bool tplayer = false;
    public float searchtimer = 2;
    public bool permission = true;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (startcountdown == true)
        {
            searchtimer -= Time.deltaTime;
        }


        if (searchtimer <= 0 || health == 0)
        {
            if (permission == true)
            {
                GameObject.Find("MainCharacter").GetComponent<PlayerAssalto_script>().earnmoneytables();
                if (health == 0)
                {
                    health = -1;
                }
            }

            startcountdown = false;
            searchtimer = 2;
            permission = false;

        }


        if (tplayer == true && Input.GetKeyDown(KeyCode.Q))
        {
            startcountdown = true;
        }

        if (Input.GetKeyUp(KeyCode.Q))
        {
            startcountdown = false;
            searchtimer = 2;
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            tplayer = true;
        }
        
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            tplayer = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            health--;
        }
    }
}

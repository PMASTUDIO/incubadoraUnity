using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vault_scipt : MonoBehaviour {

    public searchbar_script search;
    public bool permission = true;
    public int health = 3; 
    public bool tplayer = false;
    public bool password = false;
    public float searchtime = 6;
    public bool startcountdown = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (startcountdown == true && password == true)
        {
            searchtime -= Time.deltaTime;
        }
        else if (startcountdown == true && password == false)
        {
            GameObject.Find("MainCharacter").GetComponent<PlayerAssalto_script>().accessdeniedvault();
        }

        if (tplayer == true)
        {
            if (Input.GetKeyDown(KeyCode.Q))
            {
                startcountdown = true;
                search.permission = true;
                
            }

            if (startcountdown == true)
            {
                search.Search(3.0f);
            }

            if (Input.GetKeyUp(KeyCode.Q))
            {
                startcountdown = false;
                searchtime = 6;
            }
        }

        if (searchtime <= 0 && permission == true|| health == 0 && permission == true)
        {
            startcountdown = false;
            searchtime = 6;
            GameObject.Find("MainCharacter").GetComponent<PlayerAssalto_script>().earnmoneyvault();
            if(health == 0)
            {
                health = -1;
            }
            permission = false;
        }
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            tplayer = true;
        }

        if(collision.gameObject.tag == "Bullet")
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

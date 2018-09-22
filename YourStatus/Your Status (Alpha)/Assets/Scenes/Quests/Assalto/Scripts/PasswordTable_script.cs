using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PasswordTable_script : MonoBehaviour {

    public bool permission = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (permission == true && Input.GetKeyDown(KeyCode.Q))
        {
            GameObject.Find("MainCharacter").GetComponent<PlayerAssalto_script>().password = true;
            GameObject.Find("MainCharacter").GetComponent<PlayerAssalto_script>().starttexttimer();
        }

	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            permission = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        permission = false;
    }

}

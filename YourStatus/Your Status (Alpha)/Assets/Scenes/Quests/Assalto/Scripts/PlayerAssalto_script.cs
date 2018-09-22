using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerAssalto_script : MonoBehaviour {

    public Text result;
    public int prejuizo;
    public float time = 200;
    public Text timetext;
    public Text texto;
    public float texttimer = 3; 
    public Text t;
    public bool tvault = false;
    public bool password = false;
    public float moneyadd = 0;
    public float money = 0;
    public float minmoney = 600;

	// Use this for initialization
	void Start () {
        t.text = "";
        result.text = "";
    }
	
	// Update is called once per frame
	void Update () {

        time -= Time.deltaTime;

        timetext.text = "Time: " + time.ToString("f0");

        texto.color = Color.green;

        texto.text = "Money: " + money + "/" + minmoney;

        if (tvault == true && Input.GetKeyDown(KeyCode.Q) && password == true)
        {
            foreach (GameObject vaults in GameObject.FindGameObjectsWithTag("Vault"))
            {
                vaults.GetComponent<Vault_scipt>().password = true;
            }
        }

        texttimer -= Time.deltaTime;

        if (texttimer <= 0)
        {
            t.text = "";
        }

        if (time <= 0)
        {
            result.text = "You lose";
        }

    }



    public void earnmoneycashier()
    {
        moneyadd = Random.Range(70, 100);
        money += moneyadd;
        t.color = Color.yellow;
        texttimer = 3;
        t.text = "Obtained: + " + moneyadd + "$";

    }

    public void earnmoneyvault()
    {      
       moneyadd = Random.Range(275, 400);
       money += moneyadd;
       t.color = Color.yellow;
       texttimer = 3;
       t.text = "Obtained: + " + moneyadd + "$";
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Vault")
        {
            tvault = true;
        }

        if (collision.gameObject.tag == "Exit")
        {
            if (money >= minmoney)
            {
                result.text = "You Win";
            }
            else if (money < minmoney)
            {
                result.text = "You haven't collected enough money yet...";
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Vault")
        {
            tvault = false;
        }
    }

    public void starttexttimer()
    {
        t.color = Color.white;
        texttimer = 3;
        t.text = "Obtained: Vault Password";
    }

    public void accessdeniedvault()
    {
        t.color = Color.red;
        texttimer = 3;
        t.text = "Password Required";
    }

    public void earnmoneytables()
    {
        moneyadd = Random.Range(10, 45);
        money += moneyadd;
        t.color = Color.yellow;
        texttimer = 3;
        t.text = "Obtained: + " + moneyadd + "$";
    }

    public void losetime()
    {
        prejuizo = Random.Range(1, 6);

        time -= prejuizo;
    }

}

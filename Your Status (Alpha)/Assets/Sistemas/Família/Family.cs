using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Family : MonoBehaviour {

    private int cost;
    private short alive = 1;
    private int needsNumber;

    public MoneyGeneral bankAccount;
    public string[] Needs;
    public Text txtNeeds;
    public Text Cost;
    public Button payCosts;
    public Text Status;
    public GameObject panel;
    public short needsToBeAlive;
    public Text alerts;
    public Text rent;

    float timeLeft;
    float time = 5;

	// Use this for initialization
	void Start () {
        int rentCost = Random.Range(100, 500);
        rent.text = rentCost.ToString();

        timeLeft = Time.deltaTime;
        PlayerPrefs.SetInt("nAlive", (needsToBeAlive));
        PlayerPrefs.SetInt("momIsAlive", alive);

        cost = Random.Range(20, 135);
        needsNumber = Random.Range(0, Needs.Length);

        if(PlayerPrefs.GetInt("nAlive") == 1 && PlayerPrefs.GetInt("momIsAlive") == 1)
        {
            alive = (short) 1;
            needsToBeAlive = 0;
        } else if (PlayerPrefs.GetInt("momIsAlive") == 0) {
            alive = 0;
        } else
        {
            alive = (short)Random.Range(0, 1);
        }

        if(alive == 0)
        {
            Status.text = "Death!";
            WaitForSeconds wait = new WaitForSeconds(5);
            Destroy(panel);
        }

        txtNeeds.text = Needs[needsNumber];
        Cost.text = cost.ToString();
        if(alive == 1)
        {
            Status.text = "Alive!";
        } else
        {
            Status.text = "Death!";
        }
    }
	
	// Update is called once per frame
	void Update () {
        PlayerPrefs.SetInt("nAlive", (needsToBeAlive));
    }

    public void PayCosts()
    {
        if(bankAccount.Money >= cost)
        {
            Cost.text = 0.ToString();
            txtNeeds.text = "------------------------------------------------";
            needsToBeAlive = 1;
        } else
        {
            alerts.text = "You don't Have Money to do that!";
           
        }
        
    }

}

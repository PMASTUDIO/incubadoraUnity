using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyGeneral : MonoBehaviour {

    public int Money;
    private int ComputerMoney;
    public Text lblMoney;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        try
        {
            ComputerMoney = PlayerPrefs.GetInt("money");
            lblMoney.text = ComputerMoney.ToString();
            Money = ComputerMoney + Money;
        }
        catch (System.Exception e)
        {
            PlayerPrefs.SetInt("money", Money);
            lblMoney.text = ComputerMoney.ToString();
            Money = ComputerMoney + Money;
        }
    }
}

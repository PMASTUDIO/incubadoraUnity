using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DayCounter : MonoBehaviour {

    public int daysToWin;
    public int dayCount;
    public bool showPanel = false;
    public GameObject panel;
    public Button accept;
    public Button decline;
    public Text speach;
    public string guySpeach;
    public Text days;

	// Use this for initialization
	void Start () {
        speach.text = guySpeach;
        try
        {
            dayCount = PlayerPrefs.GetInt("day");
        }
        catch (System.Exception e)
        {
            dayCount = 0;
        }
        Debug.Log(dayCount);
    }
	
	// Update is called once per frame
	void Update () {
        panel.SetActive(showPanel);
        days.text = dayCount.ToString();
	}

    public void onDayEndded()
    {
        dayCount++;
        PlayerPrefs.SetInt("day", dayCount);
        if(dayCount >= daysToWin)
        {
            Debug.Log("Your journey has now ended...");
        }
    }

    public void onDayCountinued()
    {
        showPanel = false;
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayCounter : MonoBehaviour {

    public int daysToWin;
    public int dayCount;

	// Use this for initialization
	void Start () {
        try
        {
            dayCount = PlayerPrefs.GetInt("day");
        }
        catch (System.Exception e)
        {
            dayCount = 0;
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void onDayEndded()
    {
        dayCount++;
        PlayerPrefs.SetInt("day", dayCount);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayEnd : MonoBehaviour {

    public GameObject missionGuy;
    private float XpositionToWin;
    private float YpositionToWin;
    private float ZobligatedPosition;
    public DayCounter dayCounterScriptObject;

	// Use this for initialization
	void Start () {
        XpositionToWin = missionGuy.transform.position.x;
        YpositionToWin = missionGuy.transform.position.y;
        ZobligatedPosition = missionGuy.transform.position.z;
        this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, ZobligatedPosition);
    }
	
	// Update is called once per frame
	void Update () {
        if((this.transform.position.x >= (XpositionToWin - 2) && this.transform.position.x <= (XpositionToWin + 2)) && (this.transform.position.y >= (XpositionToWin - 2) && this.transform.position.y <= (XpositionToWin + 2)))
        {
            Debug.Log("ShowPanel");
            dayCounterScriptObject.enabled = true;
        }
	}

}

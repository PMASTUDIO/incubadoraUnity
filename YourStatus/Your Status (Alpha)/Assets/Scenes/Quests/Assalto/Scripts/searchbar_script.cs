using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class searchbar_script : MonoBehaviour {

    public Image bar;
    public bool permission = false;
    public float search = 100;
    public float maxsearch = 100;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float ratio = search / maxsearch;

        bar.rectTransform.localScale = new Vector3(ratio, 1, 1);

        
    }

    public void Search(float tempo)
    {
        if (permission == true)
        {
            search += tempo;
        }

     
    }
 
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Point : MonoBehaviour {
    private int numberOfPoints;
    public Text NumberOfPoints;
    public Text totalOfPointsText;
    public int totalOfPoints;
    public SpriteRenderer indicator;

    // Use this for initialization
    void Start () {
        totalOfPointsText.text = totalOfPoints.ToString();
	}
	
	// Update is called once per frame
	void Update () {
        totalOfPointsText.text = numberOfPoints.ToString();
        indicator.color = new Color(1, 0, 0, 0.8f);
    }
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        indicator.color = new Color(1, 1, 0, 1f);
        if (Input.GetKeyDown(KeyCode.Space)){
            numberOfPoints++;
            indicator.color = new Color(0, 1, 0, 1f);
        }
        Debug.Log("Colidiu");
    }

}

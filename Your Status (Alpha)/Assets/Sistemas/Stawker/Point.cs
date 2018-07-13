using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Point : MonoBehaviour
{
    private int numberOfPoints;
    public Text NumberOfPoints;
    public Text totalOfPointsText;
    public int totalOfPoints;
    public SpriteRenderer indicator;
    public Vector3 posistionMin;
    public Vector3 posistionMax;
    public MoveEntity objectWithMoveEntityScript;

    // Use this for initialization
    void Start()
    {
        totalOfPointsText.text = totalOfPoints.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        IfCollide();
        NumberOfPoints.text = numberOfPoints.ToString();
        
    }

    void IfCollide()
    {
        if (transform.position.x >= posistionMin.x && transform.position.x <= posistionMax.x)
        {
            indicator.color = new Color(1, 1, 0, 1);
            if (Input.GetKeyDown(KeyCode.Space))
            {
                indicator.color = new Color(0, 1, 0, 1);
                objectWithMoveEntityScript.stop = true;
                if(numberOfPoints >= totalOfPoints)
                {
                    Debug.Log("Win!");
                } else
                {
                    numberOfPoints++;
                }
                transform.position = new Vector3(-8.01f, 0, 0);
                objectWithMoveEntityScript.stop = false;

            }
        }else if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Perdeu");
            StopAllCoroutines();
            objectWithMoveEntityScript.StopAllCoroutines();
            objectWithMoveEntityScript.stop = true;
        } else {
            indicator.color = new Color(1, 0, 0, 0.8f);
        }

    }

}
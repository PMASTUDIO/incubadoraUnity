using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deliver : MonoBehaviour {

    //Get the object to be delivered
    public GameObject deliverItem;

	// Use this for initialization
	void Start () {
        deliverItem.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z);
	}
	
	// Update is called once per frame
	void Update () {
        if (deliverItem)
        {
            deliverItem.transform.position = new Vector3(this.transform.position.x - 0.2f, this.transform.position.y - 0.5f, this.transform.position.z - 1);
        }
        
    }

    //On Trigger Enter method
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //If the trigger collided has the tag "DeliveryPoint" then
        if (collision.CompareTag("DeliveryPoint"))
        {
            //Sell the item
            Destroy(deliverItem);

            //Change Scene
            Debug.Log("Win");
        }
    }

}
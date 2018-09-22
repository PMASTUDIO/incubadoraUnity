using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sniper_script : MonoBehaviour {

    public float reloadtime = 2;
    public bool cooldown = false;
    public Transform player;
    public float bulletspeed = 500; 
    public GameObject bullet;
    public Transform spawn;
    public float speed = 50;  


	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {

        Animator ar = gameObject.GetComponent<Animator>();
        transform.position = player.position;

        Vector3 mouse = Input.mousePosition;
        mouse = Camera.main.ScreenToWorldPoint(mouse);

        Vector2 direction = new Vector2(mouse.x - transform.position.x, mouse.y - transform.position.y);
        direction.Normalize();

        transform.right = direction;
        
        if (Input.GetMouseButtonDown(0) && reloadtime == 2)
        {
            
            ar.Play("Sniper_Shoot");
            GameObject.Find("Hostage").GetComponent<Hostage_script>().Run();
            GameObject lol = Instantiate(bullet, spawn.position, transform.rotation);
            lol.GetComponent<Rigidbody2D>().AddForce(transform.right * bulletspeed);
            cooldown = true;
        }

        if (cooldown == true)
        {
            reloadtime -= Time.deltaTime;
        }

        if (reloadtime <= 0)
        {
            cooldown = false;
            reloadtime = 2;
            ar.Play("Sniper_idle");
        }
	}
}

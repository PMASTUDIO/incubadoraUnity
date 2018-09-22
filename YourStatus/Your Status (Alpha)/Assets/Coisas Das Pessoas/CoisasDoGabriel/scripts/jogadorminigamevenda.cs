using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class jogadorminigamevenda : MonoBehaviour {

    public int bolas = 0; 
    public float timer = 90;
    public bool endgame = false;
    public Text timertext;
    public Text t;
    public Text end;
    public Text finalscore;
    public float points = 0;
	public float bspeed;
	public int number;
	public float time = 0.75f;
	public Transform Lspawn;
	public Transform Dspawn;
	public Transform Rspawn;
	public Transform Uspawn;
	public GameObject ball;
    public int angle = 90;

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        rotation();

        timertext.text = "Time Left: " + timer.ToString("f0");

        t.text = "Points:" + points;

		time -= Time.deltaTime;

		if (time <= 0 && endgame == false) 
		{
			spawn ();
            bolas++;
			time = 0.75f;
		}

        timer -= Time.deltaTime;


        if (timer <= 0)
        {
            endgame = true;
            end.text = "END";
            finalscore.text = "Final Score: " + points + "/" + bolas;
            timertext.text = "";
        }


    }


    public void rotation()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            GetComponent<Transform>().eulerAngles = new Vector3(0, 0, 270);
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            GetComponent<Transform>().eulerAngles = new Vector3(0, 0, 90);
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            GetComponent<Transform>().eulerAngles = new Vector3(0, 0, 0);
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            GetComponent<Transform>().eulerAngles = new Vector3(0, 0, 180);
        }

    }

	public void spawn()
	{
		number = Random.Range (0, 4);
        bspeed = Random.Range(5,15);

		if (number == 0)
		{
			GameObject lol = Instantiate (ball, Uspawn.position, Quaternion.identity);
			lol.gameObject.GetComponent<Rigidbody2D> ().velocity = new Vector2 (0, -bspeed);
		}

		if (number == 1)
		{
			GameObject derp = Instantiate (ball, Rspawn.position, Quaternion.identity);
			derp.gameObject.GetComponent<Rigidbody2D> ().velocity = new Vector2 (-bspeed, 0);
		}

		if (number == 2) 
		{
			GameObject g = Instantiate (ball, Dspawn.position, Quaternion.identity);
			g.gameObject.GetComponent<Rigidbody2D> ().velocity = new Vector2 (0, bspeed);
		}

		if (number == 3) 
		{
			GameObject e = Instantiate (ball, Lspawn.position, Quaternion.identity);
			e.gameObject.GetComponent<Rigidbody2D> ().velocity = new Vector2 (bspeed, 0);
		}
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "ball")
        {
            points++;
        }
    }

    public void playokay()
    {
        AudioSource audio = gameObject.GetComponent<AudioSource>();

        audio.Play();
    }


}

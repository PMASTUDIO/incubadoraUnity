using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ballscript : MonoBehaviour {

    public AudioClip okay;                  //Audio de acerto
    public float timer = 10;                //Esse timer vai determinar quando a bola vai sumir da cena

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        //timer é uma contagem regressiva
        timer -= Time.deltaTime;

        //quando o timer chegar a 0, a bola some
        if (timer <= 0)
        {
            Destroy(gameObject);
        }
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //O player tem 2 collision boxes. Uma delas tem a tag Player, a outra, Miss.
        //Caso a bola acerte a collision box player, ela vai chamar a função do script do player para tocaro som de acerto
        if (collision.tag == "Player")
        {
            GameObject.Find("playerminigamevenda").GetComponent<jogadorminigamevenda>().playokay();
            //depois ela some
            Destroy(gameObject);
        }

        if (collision.tag == "Miss")
        {
            //ded
            Destroy(gameObject);
        }
    }

}

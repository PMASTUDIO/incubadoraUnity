using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Roubar : MonoBehaviour {

    public bool canwin = false;
    public GameObject picksound;
    public GameObject Goal;
    public GameObject VictorySong;
    public GameObject AlertSong;
    public GameObject VisaoFrente;
    public GameObject VisaoLado;
    public GameObject Texto;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
	}

    void OnTriggerStay2D(Collider2D other)
    {

        Rigidbody2D rb = gameObject.GetComponent<Rigidbody2D>();

        if (other.gameObject.tag == "Goal")
        {
            // o Goal (que seria o alvo) tem uma colisão

            Texto.SetActive(true);
            //se o Jogador encostar nessa colisao, um texto dizendo como pegar itens surgira

            if (Input.GetKeyDown(KeyCode.P))
            {
                GameObject.Find("Guarda").GetComponent<ScriptGuarda>().EmGuarda();
                //se estiver colidindo com o objetivo e apertar P, o guarda entrara no modo "Em Guarda", ou seja, o player agora pode ser pego
                Goal.SetActive(false);
                //o alvo vai sumir da prateleira
                picksound.SetActive(true);
                //vai criar um som indicando que o item foi pego
                canwin = true;
                //o player agora pode sair da loja
                Texto.SetActive(false);
                //o texto explicativo ira sumir
            }
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Finish")
        {
           // essa eh a tag que eu coloquei na saida

            if (canwin == true)
            {
                VictorySong.SetActive(true);
                //se canwin == true e ele encostar na saida, tocara uma musica
                AlertSong.SetActive(false);
                //e a musica do Metal Gear Solid sera encerrada
            }
        }
    }

    public void Perdeste()
    {
        canwin = false;
        //se uma das visoes detectarem o Player, canwin sera falso, portanto o Player nao podera mais sair da loja
    }
}

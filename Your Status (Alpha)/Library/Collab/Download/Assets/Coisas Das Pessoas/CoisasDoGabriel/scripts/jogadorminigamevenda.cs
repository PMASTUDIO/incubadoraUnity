using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class jogadorminigamevenda : MonoBehaviour {

    public int bolas = 0;                       //Essa float vai ser a pontuação total no fim do jogo
    public float timer = 90;                    //Tempo que determina quando o jogo acaba
    public bool endgame = false;                //Endgame determina se o jogo acabou ou não 
    public Text timertext;                      //Texto que mostra a float timer
    public Text t;                              //texto que mostra quantos pontos o jogador fez durante o jogo
    public Text end;                            //texto escrito "End"
    public Text finalscore;                     //Basicamente, esse texto mostra a pontuação do jogador(float points) sobre a pontuação total(int bolas)
    public float points = 0;                    //Variavel que conta os pontos do jogador
	public float bspeed;                        //velocidade da bola que varia aleatoriamente
	public int number;                          //Determina aleatoriamente em qual Spawner a bola vai sair
	public float time = 0.75f;                  //Pausa de tempo entre cada novo spawn 
	public Transform Lspawn;                    //Spawner esquerdo
	public Transform Dspawn;                    //Spawner inferior
	public Transform Rspawn;                    //Spawner direito
	public Transform Uspawn;                    //Spawner superior
	public GameObject ball;                     //bola ( ͡° ͜ʖ ͡°)
    public int angle = 90;                      //Angulo que o jogador vira

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {

        //Void responsavel pela rotação do jogador
        rotation();

        //Esse texto mostra o tempo que falta de acordo com a variavel timer. ToString("f0") converte a float em uma string de apenas 2 casas (decimais e unidades)
        timertext.text = "Time Left: " + timer.ToString("f0");

        //T representa a pontuação do jogador
        t.text = "Points:" + points;

        //time NAO EH IGUAL A timeR. Time conta quanto o intervalo até que outra bola saia de um dos Spawners, nesse caso,
		time -= Time.deltaTime;

        //Quando o intervalo chegar a 0 e enquanto o jogo nao acabar
		if (time <= 0 && endgame == false) 
		{
            //Função responsavel pela criação de outras bolas 
			spawn ();
            //A pontuação total aumenta
            bolas++;
            //O intervalo reseta
			time = 0.75f;
		}


        //O tempo que falta até o jogo acabar
        timer -= Time.deltaTime;

        //Quando o tempo acabar
        if (timer <= 0)
        {
            //Como endgame = true, a função spawn() não será mais chamada
            endgame = true;
            //Um texto escrito END vai aparecer na tela do jogador
            end.text = "END";
            //final score = (pontos/pontuação total), ou seja, (points/bolas)
            finalscore.text = "Final Score: " + points + "/" + bolas;
            //timertext vai "desaparecer" da tela
            timertext.text = "";
        }


    }


    public void rotation()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            //convertendo em Vector 3, rotacionando para a direita
            GetComponent<Transform>().eulerAngles = new Vector3(0, 0, 270);
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            //convertendo em Vector 3, rotacionando para a esquerda
            GetComponent<Transform>().eulerAngles = new Vector3(0, 0, 90);
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            //convertendo em Vector 3, rotacionando para cima
            GetComponent<Transform>().eulerAngles = new Vector3(0, 0, 0);
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            //convertendo em Vector 3, rotacionando para baixo
            GetComponent<Transform>().eulerAngles = new Vector3(0, 0, 180);
        }

    }

	public void spawn()
	{
        //number vai determinar de qual spawner a bola sai, pegando um numero de 0 a 4
		number = Random.Range (0, 4);
        //A velocidade de cada bola tambem eh aleatoria, sendo a velocidade minima 5 e a maxima 15
        bspeed = Random.Range(5,15);

		if (number == 0)
		{
            //Cada numero eh um spawner diferente
			GameObject lol = Instantiate (ball, Uspawn.position, Quaternion.identity);
            //A velocidade varia 
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
            //caso a bola encoste na collision box "Player", ou seja, na area verde da sprite, o jogador ganha um ponto
            points++;
        }
    }

    public void playokay()
    {
        AudioSource audio = gameObject.GetComponent<AudioSource>();
        //Som de acerto
        audio.Play();
    }


}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Andar : MonoBehaviour {
	public Rigidbody2D self;
	public float velocidade;
    private float xscale;
    private float yscale;

    public bool running = false;
    // basicamente, se vc apertar SHIFT essa função vai virar positiva.
	
    // Use this for initialization
	void Start () {
		self = GetComponent<Rigidbody2D>();
        xscale = transform.localScale.x;
        yscale = transform.localScale.y;
    }
	
	// Update is called once per frame
    void Update()
    {
        Move();

        if (Input.GetKey(KeyCode.LeftShift))
        {
            running = true;
            //se segurar o shift esquerdo,o jogador estara correndo
        }

        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            running = false;
            //se soltar o shift esquerdo,o jogador estara andando
        }
    }

    void Move()
    {
        if (Input.GetAxis("Vertical") > 0)
        {
            self.transform.position += new Vector3(0, velocidade / 100, 0) * Time.deltaTime;
            if (running == false)
            {
                gameObject.GetComponent<Animator>().Play("JogadorAndandoFrente");
                //se o jogador NÃO estiver CORRENDO (running == false), a animação vai ser ANDANDO
            }

            else
            {
                gameObject.GetComponent<Animator>().Play("WalkingBack");
                //aqui a animacao vai ser correndo
            }
        }
        else if (Input.GetAxis("Vertical") < 0)
        {
            self.transform.position -= new Vector3(0, velocidade / 100, 0) * Time.deltaTime;
            if (running == false)
            {
                gameObject.GetComponent<Animator>().Play("PlayerAndando");
            }

            else
            {
                gameObject.GetComponent<Animator>().Play("WalkingFront");
                //aqui a animacao vai ser correndo
            }
        }

        else if (Input.GetAxis("Horizontal") > 0)
        {
            self.transform.localScale = new Vector3(xscale, yscale, 0);
            self.transform.position += new Vector3(velocidade / 100, 0, 0) * Time.deltaTime;
            if (running == false)
            {
                gameObject.GetComponent<Animator>().Play("PlayerAndandoLado");
            }

            else
            {
                gameObject.GetComponent<Animator>().Play("WalkingSide");
                //aqui a animacao vai ser correndo
            }
        }
        else if (Input.GetAxis("Horizontal") < 0)
        {
            self.transform.localScale = new Vector3(-xscale, yscale, 0);
            self.transform.position -= new Vector3(velocidade / 100, 0, 0) * Time.deltaTime;
            if (running == false)
            {
                gameObject.GetComponent<Animator>().Play("PlayerAndandoLado");
            }

            else
            {
                gameObject.GetComponent<Animator>().Play("WalkingSide");
                //aqui a animacao vai ser correndo
            }
        }

        else
        {
            gameObject.GetComponent<Animator>().Play("Idle");
        }
    }
}

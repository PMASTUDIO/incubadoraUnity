using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptGuarda : MonoBehaviour {

    //Esse script fara com que o guarda mude de posição de tempo em tempo

    public float Timer = 3;
    //Esse vai ser o tempo em que ele muda de lado
    public bool frente = true;
    //Essa variavel vai servir pra verificar se ele esta de frente ou nao

    public GameObject VisaoLado;
    //As duas visoes vao ser box colliders por enquanto. Essa vai ser quando ele estiver de lado
    public GameObject VisaoFrente;
    //e essa vai ser o campo de visao quando ele estiver de frente;

    public bool Alerta = false;

    public GameObject isded;
    public GameObject violin;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        Timer -= Time.deltaTime;
        //contagem do timer

        Animator ar = gameObject.GetComponent<Animator>();
        //definindo "ar" para o Animator

        SpriteRenderer sr = gameObject.GetComponent<SpriteRenderer>();

        if (Timer <= 0)
        {
            if (frente == true)
            {
                frente = false;
            }
            //quando o timer acabar, se o guarda estiver de frente, ele vai agora ficar de lado

            else
            {
                frente = true;
            }
            //se ele estiver de lado, ficara de frente

            Timer = 5;
            // o timer vai voltar pro seu valor original
        }

            if (frente == true)
            {
                ar.Play("GuardaFrente");
                // se frente for verdadeiro, a sprite do guarda vai ser ele encarando para frente

                if (Alerta == true)
                {
                    VisaoFrente.SetActive(true);
                    //se ele estiver de frente (frente == true),a visao de frente sera ativada

                    VisaoLado.SetActive(false);
                    //e a de lado sera desativada
                }
            }

        else
        {
            ar.Play("GuardaDeLado");
            // se nao, ele vai estar de lado

            sr.flipX = true;

            if (Alerta == true)
            {
                VisaoFrente.SetActive(false);
                VisaoLado.SetActive(true);
                //aqui eu simplesmente inverti o codigo
            }
        }
	}

    public void EmGuarda()
    {
        Alerta = true;
        // essa funcao sera ativada quando o Jogador pegar o item. Isso significa que ele podera ser pego agora
    }
}

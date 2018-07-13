using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptGuarda : MonoBehaviour {

    //Esse script fara com que o guarda mude de posição de tempo em tempo

    public float Timer = 3;
    //Esse vai ser o tempo em que ele muda de lado
    public bool frente = true;
    //Essa variavel vai servir pra verificar se ele esta de frente ou nao

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

            Timer = 3;
            // o timer vai voltar pro seu valor original
        }

        if (frente == true)
        {
            ar.Play("GuardaFrente");
        }
        // se frente for verdadeiro, a sprite do guarda vai ser ele encarando para frente

        else
        {
            ar.Play("GuardaDeLado");
        }
        // se nao, ele vai estar de lado
	}
}

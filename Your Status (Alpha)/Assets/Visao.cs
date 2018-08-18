using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Visao : MonoBehaviour {

    public GameObject isded;
    public GameObject Alertsong;
    public GameObject AlertSound;
    public GameObject falaguarda;
    public GameObject textbox;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.tag == "Player")
        {
            GameObject.Find("MainCharacter").GetComponent<Roubar>().Perdeste();
            // se a visao colidir com o Jogador, a funcao Perdeste do player sera ativada, ou seja, ele nao podera sair da loja
            GameObject.Find("Guarda").GetComponent<ScriptGuarda>().TheWorld();
            //essa funcao do guarda serve pra congelar ele na posicao que ele esta, assim ele nao fica mudando de lado mesmo depois que o jogador foi pego
            isded.SetActive(true);
            Alertsong.SetActive(false);
            falaguarda.SetActive(true);
            AlertSound.SetActive(true);
            textbox.SetActive(true);
            // esses GameObjects sao so sons e a fala do guarda
        }

    }
}

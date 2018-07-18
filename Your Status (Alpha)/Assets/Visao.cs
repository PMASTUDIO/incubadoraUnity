using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Visao : MonoBehaviour {

    public GameObject isded;
    public GameObject violin;
    public GameObject Alertsong;
    public GameObject AlertSound;

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
            isded.SetActive(true);
            violin.SetActive(true);
            Alertsong.SetActive(false);
            AlertSound.SetActive(true);
            // esses GameObjects sao so sons
        }

    }
}

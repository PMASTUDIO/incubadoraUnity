using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jogador : MonoBehaviour {

    //Basicamente, a camera tava meio bugada, ent eu fiz um Empty q vai envolver o Player e a Camera. Esse empty vai seguir o Player, pra isso q serve esse script

    public Transform Player;
    //Ele vai seguir a posição do Player, portanto preciso do transform dele.


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.position = new Vector2 (Player.position.x, Player.position.y);
        //a posição do empty vai ser a posição x e y do Player
	}
}

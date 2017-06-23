using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	public GameObject Player;

	private Vector3 offset;

	// Use this for initialization
	void Start () {
		//distancia da camera para o jogador
		offset = transform.position - Player.transform.position; 
	}
	
	// Update is called once per frame
	void LateUpdate () {
		// A camera terá a distância dela para o jagador, somada a posição do jogador.
		transform.position = Player.transform.position + offset; 
	}
}

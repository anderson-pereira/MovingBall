using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MovingBallController : MonoBehaviour {

	public float speed;
	public Text countText;
	public Text winText;

	private Rigidbody rb;
	private int count;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
		count = 0;
		SetCountText ();
		winText.text = "";
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		float moveHorizontal = Input.GetAxis ("Horizontal");	//o valor do eixo horizontal será armazenado
		float moveVertical = Input.GetAxis ("Vertical");		//o valor do eixo vertical será armazenado

		Vector3 movement = new Vector3 (moveHorizontal, 0, moveVertical);	//Vector3 que vai receber o direcionamento do jogador

		rb.AddForce (movement * speed);	//adiciona uma força no rigidbody do jogador, na nova posição especificada, multiplicando-a pela velocidade escolhida
	}

	void OnTriggerEnter(Collider other){
		if (other.gameObject.CompareTag("Pick Up")){
			other.gameObject.SetActive (false);
			count = count + 1;
			SetCountText ();
		}
	}

	void SetCountText (){
		countText.text = "Count: " + count.ToString ();
		if (count >= 13) {
			winText.text = "Great Victory!";
		}
	}
}

﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameControl : MonoBehaviour {

	public PlayerProperty ppInstance;

	public Text endText;


	void OnCollisionEnter2D (Collision2D player) {
		
		Renderer spnRend = this.GetComponent<Renderer> ();

		if (player.gameObject.tag == "Player") {
			if (ppInstance.player.rend.material.color != spnRend.material.color)
				endText.text = "Game Over!";
			else
				Destroy (this.gameObject);
		}
	}

}

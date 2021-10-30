using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCController: MonoBehaviour {
	private GameObject player;

	void Awake() {
		player = GameObject.FindGameObjectWithTag( "Player" );
	}

	void OnTriggerEnter(Collider other) {
		if(other.gameObject == player && other.isTrigger == false) {
			ScoreManager.instance.addScore();
			this.gameObject.SetActive( false );
		}
	}
}

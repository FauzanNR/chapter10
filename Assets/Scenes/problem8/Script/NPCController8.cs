using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCController8: MonoBehaviour {

	float time = 0f;
	private GameObject player;

	void Awake() {
		player = GameObject.FindGameObjectWithTag( "Player" );
	}

	void OnDisable() {
		Invoke( "activate", 3 );
	}

	void activate() {
		transform.position = ObjectPool8.instance.generateRandomPosition();
		this.gameObject.SetActive( true );
	}

	void OnTriggerEnter(Collider other) {
		if(other.gameObject == player && other.isTrigger == false) {
			ScoreManager.instance.addScore();
			this.gameObject.SetActive( false );
		}
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.PlayerLoop;

public class BallMovement4: MonoBehaviour {
	public float speed = 100;
	private Rigidbody rg;
	void Awake() {
		rg = GetComponent<Rigidbody>();
	}

	void FixedUpdate() {
		var h = Input.GetAxisRaw( "Horizontal" );
		var v = Input.GetAxisRaw( "Vertical" );
		move( h, v );
	}

	void move(float horizontal, float vertical) {
		var position = new Vector3( horizontal, 0f, vertical );
		position = position.normalized * speed;
		rg.AddForce( position );
	}
}

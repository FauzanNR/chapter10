using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement: MonoBehaviour {
	public float speed = 100;
	private Rigidbody rg;
	void Start() {
		rg = GetComponent<Rigidbody>();
		InvokeRepeating( "move", 2, 5 );

	}

	void move() {
		rg.velocity = transform.forward * Time.deltaTime * speed;
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NPCMovement7: MonoBehaviour {
	public float runDistance = 4f;
	GameObject player;
	NavMeshAgent navMeshAgent;

	void Start() {
		navMeshAgent = GetComponent<NavMeshAgent>();
		player = GameObject.FindGameObjectWithTag( "Player" );
	}


	void Update() {
		float distance = Vector3.Distance( transform.position, player.transform.position );

		if(distance < runDistance) {
			Vector3 playerDirection = transform.position - player.transform.position;
			Vector3 newDirection = transform.position + playerDirection;
			navMeshAgent.SetDestination( newDirection );
		}
	}
}

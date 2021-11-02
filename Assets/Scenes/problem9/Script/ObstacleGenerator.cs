using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ObstacleGenerator: MonoBehaviour {

	public int maxObstacle;
	public GameObject obstaclePrefab;

	void Start() {
		var randomNumber = Random.Range( 1, maxObstacle );
		for(int i = 0; i < randomNumber; i++) {
			var obj = Instantiate(
					obstaclePrefab,
					ObjectPool9.instance.generateRandomPosition(),
				  	Quaternion.AngleAxis( Random.Range( 1, 180 ), Vector3.up )
			  );
		}
	}
}

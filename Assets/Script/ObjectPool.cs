using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool: MonoBehaviour {


	public LayerMask layer;
	public int maxNPCNumber = 5;
	GameObject ground;
	[SerializeField] private GameObject npcPrefab;
	private List<GameObject> npcPool = new List<GameObject>();
	float scale = 1f;
	float time = 0.0f;
	public static ObjectPool instance {
		get;
		private set;
	}
	void Awake() {
		instance = this;
		ground = GameObject.FindGameObjectWithTag( "Ground" );
	}
	void Start() {
		var randomNumber = Random.Range( 1, maxNPCNumber );
		for(int i = 0; i < randomNumber; i++) {
			var obj = Instantiate( npcPrefab, generateRandomPosition(), Quaternion.identity );
			npcPool.Add( obj );
		}
	}

	void Update() {
		//var npcs = respawnNpc();
		//Debug.Log( npcs );
		//if(npcs != null) {
		//	time += Time.deltaTime;
		//	int seconds = ( int )(time % 60);
		//	Debug.Log( seconds );
		//	if(seconds == 3) {
		//		npcs.transform.position = generateRandomPosition();
		//		npcs.SetActive( true );
		//		seconds = 0;
		//		time = 0.0f;
		//	}
		//}
	}

	public Vector3 generateRandomPosition() {

		float moveAreaX = ground.GetComponent<Renderer>().bounds.size.x / 2;
		float moveAreaZ = ground.GetComponent<Renderer>().bounds.size.z / 2;
		Vector3 center = ground.GetComponent<Renderer>().bounds.center;

		var targetCoordsX = center.x + Random.Range( -moveAreaX * scale, moveAreaX * scale );
		var targetCoordsZ = center.z + Random.Range( -moveAreaZ * scale, moveAreaZ * scale );
		var position = new Vector3( targetCoordsX, 0.5f, targetCoordsZ );

		while(Physics.CheckSphere( position, 1, layer )) {
			targetCoordsX = center.x + Random.Range( -moveAreaX * scale, moveAreaX * scale );
			targetCoordsZ = center.z + Random.Range( -moveAreaZ * scale, moveAreaZ * scale );
			position = new Vector3( targetCoordsX, 0.5f, targetCoordsZ );
			Debug.Log( "collide" );
		}

		return position;
	}

	//GameObject respawnNpc() {
	//	foreach(var npc in npcPool) {
	//		if(!npc.activeInHierarchy) {
	//			return npc;
	//		}
	//	}
	//	return null;
	//}
}

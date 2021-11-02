using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool7: MonoBehaviour {
	//ObjectPool instance;
	public int maxNPCNumber = 5;
	GameObject ground;
	[SerializeField] private GameObject npcPrefab;
	private List<GameObject> npcPool = new List<GameObject>();
	//Transform position;
	float scale = 1f;


	void Start() {
		ground = GameObject.FindGameObjectWithTag( "Ground" );
		float moveAreaX = ground.GetComponent<Renderer>().bounds.size.x / 2;
		float moveAreaZ = ground.GetComponent<Renderer>().bounds.size.z / 2;
		Vector3 center = ground.GetComponent<Renderer>().bounds.center;

		var randomNumber = Random.Range( 1, maxNPCNumber );
		for(int i = 0; i < randomNumber; i++) {

			var targetCoordsX = center.x + Random.Range( -moveAreaX * scale, moveAreaX * scale );
			var targetCoordsZ = center.z + Random.Range( -moveAreaZ * scale, moveAreaZ * scale );

			//Debug.Log( new Vector3( targetCoordsX, 0.5f, targetCoordsZ ) );
			var position = new Vector3( targetCoordsX, 0.5f, targetCoordsZ );

			var obj = Instantiate( npcPrefab, position, Quaternion.identity );
			//obj.SetActive( false );
			npcPool.Add( obj );
		}
	}

	// Update is called once per frame
	void Update() {

	}
}

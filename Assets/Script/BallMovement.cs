using UnityEngine;

public class BallMovement: MonoBehaviour {

	public LayerMask layerMask;
	public Camera camera;
	public float speed = 100;
	private Rigidbody rg;

	void Awake() {
		rg = GetComponent<Rigidbody>();
	}

	void FixedUpdate() {
		Ray ray = camera.ScreenPointToRay( Input.mousePosition );
		if(Physics.Raycast( ray, out RaycastHit rayHit, float.MaxValue, layerMask ) && Input.GetMouseButton( 0 )) {
			move( rayHit.point );
		}
	}

	void move(Vector3 position) {
		position = position - transform.position;
		position = position.normalized * speed;
		rg.AddForce( position );
	}
}

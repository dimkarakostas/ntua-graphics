using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

	//modify speed in game inspector
	public float speed = 2.0f;

	// Use this for initialization
	void Start () {
		//initial move
		rigidbody2D.velocity = Vector2.one.normalized * speed;	
	}


float hitFactor(Vector2 ballPos, Vector2 racketPos, float racketHeight) {
	return (ballPos.y - racketPos.y) / racketHeight;
}

void OnCollisionEnter2D(Collision2D col) {
	
	// Hit the left Racket?
	if (col.gameObject.name == "RacketLeft") {
		// Calculate hit Factor
		float y=hitFactor(transform.position,
		                  col.transform.position,
		                  ((BoxCollider2D)col.collider).size.y);

		// Calculate direction, set length to 1
		Vector2 dir = new Vector2(1, y).normalized;

		
		// Set Velocity with dir * speed
		rigidbody2D.velocity = dir * speed;
		
	}
	
	// Hit the right Racket?
	if (col.gameObject.name == "RacketRight") {
		
		// Calculate hit Factor
		
		float y=hitFactor(transform.position,
		                  col.transform.position,
		                  ((BoxCollider2D)col.collider).size.y);
		
		// Calculate direction, set length to 1
		Vector2 dir = new Vector2(-1, y).normalized;
		
		// Set Velocity with dir * speed
		rigidbody2D.velocity = dir * speed;
	}
}
}
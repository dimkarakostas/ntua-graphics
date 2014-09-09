using UnityEngine;
using System.Collections;

public class RacketMovement : MonoBehaviour {
	
	// up and down keys (set in the game Inspector)
	public KeyCode up;
	public KeyCode down;
	//public float pos;
	// Update is called once per frame
	void FixedUpdate () {

		if (Input.GetKey (up)) {
			transform.Translate(new Vector2(0.0f, 0.1f));
				}

		if (Input.GetKey (down)) {
			transform.Translate(new Vector2(0.0f, -0.1f));
				}
		//pos = transform.position.y;
		//if (pos>3.235734f){
		//	pos=3.235734f;
		//}
	}
}

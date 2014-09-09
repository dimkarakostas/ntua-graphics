#pragma strict

var smooth:float = 25.0;
var speed:float = 25.0;


function Start () {
	rigidbody2D.AddForce(transform.forward * speed * 0.005);
}

function Update () {
	var veloc1=rigidbody2D.velocity;
	var veloc2=veloc1.normalized * speed;
	rigidbody2D.velocity = Vector3.Lerp(veloc1,veloc2,Time.deltaTime * smooth);
}
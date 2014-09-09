#pragma strict
var speed : int;

function Start () {

	rigidbody2D.AddForce(Random.onUnitSphere * speed * 0.005);
}

function Update () {

}
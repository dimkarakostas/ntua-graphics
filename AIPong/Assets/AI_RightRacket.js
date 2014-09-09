#pragma strict

var ball:GameObject;
var speed:float=15.0;

function Update () {
 // Right Racket follows the ball
 
 if (ball.transform.position.y > transform.position.y){
 	transform.Translate(Vector3(0,speed,0) * Time.deltaTime);
 	
 }
 
 if (ball.transform.position.y < transform.position.y){
 	transform.Translate(Vector3(0,-speed,0) * Time.deltaTime);
 	
 }
 
 if (transform.position.y > 3.34){
 	transform.position.y = 3.34;
 }

 if (transform.position.y < -3.34){
 	transform.position.y = -3.34;
 }

}
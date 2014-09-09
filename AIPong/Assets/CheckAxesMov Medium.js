#pragma strict


function Update () {
 	if (rigidbody2D.velocity.x==0.5){
		
		rigidbody2D.velocity.x=-5.5;
	}
	
	if (rigidbody2D.velocity.y==0.5){
		
		rigidbody2D.velocity.y=-5.5;
	}
}
#pragma strict



function Update () {
	if (rigidbody2D.velocity.x==0.5){
		
		rigidbody2D.velocity.x=-4.8;
	}
	
	if (rigidbody2D.velocity.y==0.5){
		
		rigidbody2D.velocity.y=-4.8;
	}
}
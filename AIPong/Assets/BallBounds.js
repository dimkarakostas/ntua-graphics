#pragma strict


static var leftScore:int = 0;
static var rightScore:int = 0;
function Update () {
//Check right bounds
	if (transform.position.x > 7){
		leftScore++;
		
		transform.position.x=0;
		transform.position.y=0;
		//rigidbody2D.velocity.y=0;
	}
	
	//Check left bounds
	if (transform.position.x < -7){
		rightScore++;
		
		transform.position.x=0;
		transform.position.y=0;
		//rigidbody2D.velocity.y=0;
	}
	
	
}
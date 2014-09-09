#pragma strict

var lScore:GUIText;
var rScore:GUIText;

function OnGUI() {
	lScore.text= "" + BallBounds.leftScore;
	rScore.text= "" + BallBounds.rightScore;
}

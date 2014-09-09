#pragma strict


function OnGUI() {
	if (GUI.Button(Rect(10,10,55,30), 'Pause'))
		togglePause();
	else if (GUI.Button(Rect(10,50,50,30), 'Menu')) {
		BallBounds.leftScore = 0;
		BallBounds.rightScore = 0;
		Time.timeScale = 1f;
		Application.LoadLevel("NewMainMenu");
	}
	else if (GUI.Button(Rect(10,190,50,30), 'Quit'))
		Application.Quit();
		
	if ((BallBounds.leftScore >= 10) || (BallBounds.rightScore >=10)) {
		Time.timeScale = 0f;
		GameOver();
	}
}
		
		
function togglePause()
{
	if (Time.timeScale == 0f) {
		Time.timeScale = 1f;
	}

	else {
		Time.timeScale = 0f;
	}
}


function GameOver() {
	if (GUI.Button(Rect(10,150,90,30), 'Play Again')) {
		BallBounds.leftScore = 0;
		BallBounds.rightScore = 0;
		Time.timeScale = 1f;
		Application.LoadLevel(Application.loadedLevel);
	}
}
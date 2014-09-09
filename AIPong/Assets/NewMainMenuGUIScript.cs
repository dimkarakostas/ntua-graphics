using UnityEngine;
using System.Collections;

public class NewMainMenuGUIScript : MonoBehaviour {

	void OnGUI() {
		GUILayout.BeginArea ( new Rect( Screen.width / 2 - 100, Screen.height / 2 -100, 200, 200));
		GUILayout.FlexibleSpace();
		if (GUILayout.Button ("1-Player Mode")) {
			Application.LoadLevel("Levels");

				}
		if (GUILayout.Button ("2-Player Mode")) {
			Application.LoadLevel("Instructions2pl");
			
		}

		if (GUILayout.Button ("Quit")) {
			Application.Quit();
			
		}

		GUILayout.FlexibleSpace();
		GUILayout.EndArea();

	}
}

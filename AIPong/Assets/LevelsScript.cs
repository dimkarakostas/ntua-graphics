using UnityEngine;
using System.Collections;

public class LevelsScript : MonoBehaviour {

	void OnGUI() {
		GUILayout.BeginArea ( new Rect( Screen.width / 2 - 100, Screen.height / 2 -100, 200, 200));
		GUILayout.FlexibleSpace();

		if (GUILayout.Button ("Easy")) {
			Application.LoadLevel("AIeasy");
			
		}

		if (GUILayout.Button ("Medium")) {
			Application.LoadLevel("AIMedium");
			
		}

		if (GUILayout.Button ("Hard")) {
			Application.LoadLevel("AIHard");
			
		}

		if (GUILayout.Button ("Back")) {
			Application.LoadLevel ("NewMainMenu");
		}

		if (GUILayout.Button ("Quit")) {
			Application.Quit();
			
		}
		
		GUILayout.FlexibleSpace();
		GUILayout.EndArea();
		
	}
}

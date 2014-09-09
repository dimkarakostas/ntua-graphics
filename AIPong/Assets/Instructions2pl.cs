using UnityEngine;
using System.Collections;

public class Instructions2pl : MonoBehaviour {

	void OnGUI() {
		GUILayout.BeginArea ( new Rect( Screen.width / 2 - 100, Screen.height / 2 -100, 200, 200));
		GUILayout.FlexibleSpace();
		if (GUILayout.Button ("OK")) {
			Application.LoadLevel("2players");
			
		}
		if (GUILayout.Button ("Back")) {
			Application.LoadLevel("NewMainMenu");
			
		}
		
		if (GUILayout.Button ("Quit")) {
			Application.Quit();
			
		}
		
		GUILayout.FlexibleSpace();
		GUILayout.EndArea();
		
	}
}

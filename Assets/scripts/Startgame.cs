using UnityEngine;
using System.Collections;

public class Startgame : MonoBehaviour {

	void OnGUI () {
		if (GUI.Button(new Rect(Screen.width / 2 - 100, Screen.height / 2 - 15, 200, 30), "Start")) {
			Application.LoadLevel("minigame");
		}
		    
	}
}

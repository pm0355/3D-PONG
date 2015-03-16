using UnityEngine;
using System.Collections;

public class WinGUI : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnGUI(){
		GUI.Box(new Rect(600,400, 200, 100), "YOU WON");
		if (GUI.Button(new Rect(600,500,200,100), "Click to play again"))
			Application.LoadLevel("reset");
	}
}

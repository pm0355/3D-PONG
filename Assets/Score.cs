using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour {
	
	public static int score;
	
	GameObject b = GameObject.Find ("Ball");
	
	void start(){
		//DontDestroyOnLoad (transform.gameObject);
	}
	
	void OnGUI(){
		
		GUI.Box(new Rect(40,5,150,50),"PlayerScore" + score);
		if (score == 10) {
			
			Application.LoadLevel ("Win");	
			score =0;
		}
	}
	
	
	
	void Update(){
		
		
		/*void BallReset(){
				transform.position = transform.position;
}
*/
		
	}
}

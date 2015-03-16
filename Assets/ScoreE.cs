using UnityEngine;
using System.Collections;

public class ScoreE : MonoBehaviour {

	public static int escore;

	GameObject b = GameObject.Find ("Ball");

	void start(){
				//DontDestroyOnLoad (transform.gameObject);
		}

	void OnGUI(){
		
		GUI.Box(new Rect(960,5,150,50),"Opponent Score" + escore);
		if (escore == 10) {
						
								Application.LoadLevel ("Lose");	
			escore =0;
						}
				}



	void Update(){

	
			/*void BallReset(){
				transform.position = transform.position;
}
*/

	}
}

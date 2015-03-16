using UnityEngine;
using System.Collections;

public class incrementW : MonoBehaviour {
	// Use this for initialization
	void Start () {
		//DontDestroyOnLoad (transform.gameObject);
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnCollisionEnter(Collision collision){
		if (collision.gameObject.name == "Ball") {
			
			Score.score = Score.score + 1;
			Application.LoadLevel ("reset");
		}
		
	}
}

using UnityEngine;
using System.Collections;

public class momentumori : MonoBehaviour {
	public Transform Ball;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnCollisionEnter(Collision collision){
		if(collision.gameObject.name =="Ball"){
			GameObject b = GameObject.Find ("Ball");
			b.rigidbody.AddForce(0,0,500);
		}
	
}
}
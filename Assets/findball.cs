using UnityEngine;
using System.Collections;

public class findball : MonoBehaviour {
	public Transform ball;
	public float speed;
		

	
	// Update is called once per frame
	void Update () {
				speed = Time.deltaTime * 20;
				if (ball.position.x >= transform.position.x +3) {
						transform.Translate (Vector3.right * speed);
				} 
			else if (ball.position.x <= transform.position.x -3) {
						transform.Translate (Vector3.left * speed);
				}

		}
	 void OnCollisionEnter(Collision collision){
		if(collision.gameObject.name == "ball"){
			collision.rigidbody.AddForce(30,0,0);
		}

}
}
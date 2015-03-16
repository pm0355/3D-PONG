using UnityEngine;
using System.Collections;

public class ballstart : MonoBehaviour {
	public int speed = 2000;
	// Use this for initialization
	void Start () {
				int randD = Random.Range (1, 2);
				if (randD == 1) {
						rigidbody.AddForce (Vector3.forward * speed);
				}
				if (randD == 2) {
						rigidbody.AddForce (Vector3.back * speed);

				}
		}
	// Update is called once per frame
	void Update () {
	
}
	}

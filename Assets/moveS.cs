using UnityEngine;
using System.Collections;

public class moveS : MonoBehaviour {
	float speed =74.0f;
	public bool rightcolliding = false;
	public bool leftcolliding = false;
	// Use this for initialization
	void Start () {
//		CharacterController cc = GameObject.GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {
	if (Input.GetKey ("left") && leftcolliding == false) {
						transform.Translate ((-Time.deltaTime * speed), 0, 0);
			rightcolliding = false;
				}
		if (Input.GetKey ("left") && leftcolliding == true) {

			rightcolliding = false;
		}
		
		if (Input.GetKey ("right") && rightcolliding ==false) {
						transform.Translate ((Time.deltaTime * speed), 0, 0);
			leftcolliding = false;

				}
		if (Input.GetKey ("right") && rightcolliding == true) {
	
			leftcolliding = false;
		}
	}
	public void OnTriggerEnter(){
		rightcolliding = true;
		leftcolliding = true;
		   }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rocket : MonoBehaviour {
	Rigidbody rigidBody;
	// Use this for initialization
	void Start () {
	rigidBody=GetComponent<Rigidbody>();
		
	}
	
	// Update is called once per frame
	void Update () {
		ProcessInput();	
	}
	void ProcessInput()
	{
		if(Input.GetKey(KeyCode.Space))
		{
			rigidBody.AddRelativeForce(Vector3.up);
		}
		 if(Input.GetKey(KeyCode.A))
		{
			print("left rotation.");
		}
		else if(Input.GetKey(KeyCode.D))
		{
			print("right rotation.");
		}
		
	}
}

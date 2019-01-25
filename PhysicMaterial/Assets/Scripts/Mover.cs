using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour {
	public float force = 100F;
	public float torqueForce = 5F;
	public Vector3 direction = Vector3.forward;
	public Vector3 directionTorque = Vector3.up;
	private Rigidbody rigidbody;
	// Use this for initialization
	void Start () {
		rigidbody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Space)){
			rigidbody.AddForce(direction * force, ForceMode.Impulse);
			rigidbody.AddTorque(directionTorque * torqueForce, ForceMode.Force);
		}
	}
}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Acciones : MonoBehaviour {
	public float fuerzaSalto = 0.01f;
	public float fuerzaEmpuje = 20f;
	private float umbralVelocidad = 0.10f;
	public Rigidbody rigidbody;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButtonDown("Jump") && Mathf.Abs(rigidbody.velocity.y) <= umbralVelocidad){
			rigidbody.AddForce(Vector3.up * fuerzaSalto, ForceMode.Impulse);
			//rigidbody.AddTorque(Vector3.forward * fuerzaSalto, ForceMode.Impulse);
		}
	}

	void FixedUpdate(){
		// Mover la bola con física
		Vector3 fuerza = new Vector3(Input.GetAxis("Horizontal") * fuerzaEmpuje, 0, Input.GetAxis("Vertical") * fuerzaEmpuje);
		rigidbody.AddForce(fuerza);
	}

	void OnCollisionEnter(Collision collision){
		if(collision.gameObject.tag.Equals("Target")){
			Color color = collision.gameObject.GetComponent<MeshRenderer>().material.color;
			switch(getColorId(color)){
				case 0:
					collision.gameObject.GetComponent<MeshRenderer>().material.color = Color.blue;					
					break;
				case 1:
					collision.gameObject.GetComponent<MeshRenderer>().material.color = Color.black;
					break;
				case 2:
					Destroy(collision.gameObject);
					break;
			}
		}
	}

	private int getColorId(Color color){
		int flag = -1;
		if(color == Color.green){
			flag = 0;
		}else if(color == Color.blue){
			flag = 1;
		}else if(color == Color.black){
			flag = 2;
		}
		return flag;
	}
}

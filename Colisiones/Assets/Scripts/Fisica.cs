using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fisica : MonoBehaviour {
	private Rigidbody rigidbody;
	private float y = 0f;
	public float _velocidad = 10F;
	// Use this for initialization
	void Start () {
		rigidbody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		
		if(Input.GetKeyDown(KeyCode.Space)){
			y = _velocidad * 5;
		}
		Vector3 fuerzaEmpuje = new Vector3(Input.GetAxis("Horizontal") * _velocidad, y, Input.GetAxis("Vertical") * _velocidad);
		rigidbody.AddForce(fuerzaEmpuje, ForceMode.Force);
		y = 0;
	}

	void FixedUpdate(){
		// Basado en el tiempo. Va a una frecuencia constante
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prueba : MonoBehaviour {
	public Transform _objeto;
	public float _destinoEnX = 5F;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetAxis("Jump") != 0){
			_objeto.transform.position = Vector3.right * _destinoEnX;
		}
		
	}
}

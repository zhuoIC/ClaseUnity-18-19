using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereRay : MonoBehaviour {
	Vector3 posInicial;
	float radio;
	Vector3 direccion;
	RaycastHit raycast;
	float distancia;
	// Use this for initialization
	void Start () {
		radio = transform.localScale.x /2;
		direccion = Vector3.right;
		distancia = 100;
	}
	
	// Update is called once per frame
	void Update () {
		// personaje = gameObject.GetComponent<CharacterController>();
	}
}

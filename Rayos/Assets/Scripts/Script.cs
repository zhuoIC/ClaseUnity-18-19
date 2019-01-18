using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script : MonoBehaviour {
	GameObject emisor;
	Vector3 direccion;
	const float alcance = 1000;
	// Use this for initialization
	void Start () {
		emisor = GameObject.Find("Emisor");
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(Vector3.up);
		direccion = emisor.transform.TransformDirection(Vector3.up * alcance);
		Debug.DrawRay(emisor.transform.position, direccion, Color.blue);
		
		/*
		RaycastHit hit;
		if(Physics.Raycast(emisor.transform.position, direccion, out hit)){
			Debug.Log("DETECTADO: " + hit.transform.gameObject.name);
		}*/
		RaycastHit[] detectados = Physics.RaycastAll(emisor.transform.position, direccion);
		foreach (RaycastHit item in detectados)
		{
			Debug.Log("DETECTADO: NOMBRE-> " + item.transform.name
			+ " TIPO -> " + item.transform.GetType().ToString()
			+ ". DISTANCIA -> " + item.distance.ToString());
		}

	}
}

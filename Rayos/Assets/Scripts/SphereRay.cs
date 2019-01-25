using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SphereRay : MonoBehaviour {
	public Text info;
	Vector3 posInicial;
	float radio;
	Vector3 direccion;
	RaycastHit raycast;
	float distancia;
	// Use this for initialization
	void Start () {
		radio = transform.localScale.x *2;
		direccion = Vector3.right;
		distancia = 1000;
	}
	
	// Update is called once per frame
	void Update () {
		// personaje = gameObject.GetComponent<CharacterController>();
		posInicial = transform.position;
		Debug.DrawRay(posInicial, direccion, Color.blue);
		if(Physics.SphereCast(posInicial, radio, direccion, out raycast, distancia)){
			info.text = string.Format("Detectando obstaculo {0} en {1:F2} metros", raycast.collider.name, raycast.distance);
		}else{
			info.text = "No detecto nada";
		}
	}
}

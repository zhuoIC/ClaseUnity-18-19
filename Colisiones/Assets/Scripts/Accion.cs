using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Accion : MonoBehaviour {
	public Transform origen, destino;
	public float _velocidad = 0.01F;
	// Use this for initialization
	void Start () {
		//Time.fixedDeltaTime = 0.04f;
	}
	
	// Update is called once per frame
	void Update () {
		origen.Translate(destino.position *_velocidad);
	}

	void FixedUpdate(){
		// Basado en el tiempo. Va a una frecuencia constante
	}
}

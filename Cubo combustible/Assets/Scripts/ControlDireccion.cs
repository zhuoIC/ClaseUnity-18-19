using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlDireccion : MonoBehaviour {

	public bool sigueCubo;
	private Transform _cubo;
	private float ejeX = 90;
	private float ejeY = 0;
	private float ejeZ = 0;
	private const string OBJECT = "Cube";
	private const string CANVAS = "Canvas";
	// Use this for initialization
	private void Start () {
		sigueCubo = false;
		_cubo = GameObject.Find(OBJECT).GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
		_cubo.transform.Rotate(Vector3.up);
		if(!sigueCubo){
			GameObject.Find(CANVAS).GetComponent<Transform>().rotation = Quaternion.Euler(ejeX, ejeY, ejeZ);
		}
	}
}

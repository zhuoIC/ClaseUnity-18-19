using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zoom : MonoBehaviour {

	float _valorZoom = 1;
	float _increment = 0.3f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		_valorZoom = Input.GetAxis("Zoom");
		transform.localScale += new Vector3(_valorZoom * _increment * Time.deltaTime,
		 _valorZoom * _increment * Time.deltaTime,
		  _valorZoom * _increment * Time.deltaTime);
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour {
	float _velocidad = 5f;
	float _lecturaInput;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		/*Debug.Log("Hola caracola...");
		_lecturaInput = Input.GetAxis("Horizontal");
		if(_lecturaInput == 1){
			transform.Translate(_velocidad, 0, 0);
			Debug.Log("Entrada: " + _lecturaInput.ToString());
		}*/
		transform.Translate(Input.GetAxis("Horizontal") * _velocidad * Time.deltaTime, 0, Input.GetAxis("Vertical") * _velocidad * Time.deltaTime);
		if(transform.position.x <= -4){
			transform.position = new Vector3(-4, transform.position.y, transform.position.z);
		}
		if(transform.position.x >= 4){
			transform.position = new Vector3(4, transform.position.y, transform.position.z);
		}
		if(transform.position.z <= -4){
			transform.position = new Vector3(transform.position.x, transform.position.y, -4);
		}
		if(transform.position.z >= 4){
			transform.position = new Vector3(transform.position.x, transform.position.y, 4);
		}
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptCamera : MonoBehaviour {
	Ray pulsacion ;
	RaycastHit raycast;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0)){
			pulsacion = GetComponent<Camera>().ScreenPointToRay(Input.mousePosition);
			if(Physics.Raycast(pulsacion, out raycast)){
				if(raycast.collider.GetComponent<Renderer>().material.color != Color.red)
					raycast.collider.GetComponent<Renderer>().material.color = Color.red;
				else
					Destroy(raycast.transform.gameObject);
				Debug.Log(raycast.collider.name);
			}
		}
	}
}

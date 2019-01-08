using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddButton : MonoBehaviour {

	public GameObject button, padre;
	// Use this for initialization
	void Start () {
		button = GameObject.Find("Button");
		padre = GameObject.Find("Panel");
	}
	
	// Update is called once per frame
	void Update () {
		// Añado el Clon de button como hijo del gameobject Panel
	}

	public void Add(){
		Instantiate(button, padre.transform);
	}
}

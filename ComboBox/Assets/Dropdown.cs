using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//------------------------------------
using UnityEngine.UI;

public class Dropdown : MonoBehaviour {

	public Text opcion;
	public UnityEngine.UI.Dropdown _dropdown;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OpcionSeleccionada(){
		opcion.text = _dropdown.value.ToString() + " -> " + _dropdown.options[_dropdown.value].text;
	}
}

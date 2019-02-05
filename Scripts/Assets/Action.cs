using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Action : MonoBehaviour {
	int count = 0;
	// Use this for initialization
	void Start () {
		MostrarHijos();
	}
	
	// Update is called once per frame
	void Update () {
		ChildToRed("pepe");
		AddChilds();
		if(Input.GetKeyDown(KeyCode.Space)){
			flag = !flag;
		}
	}

	void MostrarHijos(){
		foreach (Transform item in transform)
		{
			Debug.Log("Hijo:" + count++ + ", Nombre:" + item.name);
		}
	}

	void ChildToRed(string n){
		transform.Find(n).GetComponent<Renderer>().material.color = Color.red;
	}

	public Transform padre;
	int i = 0;

	void AddChilds(){
		// Agregar hijos al pulsar el botón izquierdo del ratón
		if(Input.GetMouseButtonDown(0)){
			GameObject hijo = new GameObject("Hijo_"+i++);
			hijo.transform.SetParent(padre);
		}
		if(Input.GetMouseButtonDown(1)){
			if(padre.childCount > 0){
				string child = padre.GetChild(0).name;
				if(child != null){
					Destroy(padre.Find(child).gameObject);
				}
			}
		}
		GameObject.Find("");
	
	}

	bool flag = false;
	public GUIStyle style;

	private void OnGUI() {
		string mensaje = "Hola caracola centrado";
		Rect area = new Rect((Screen.width/2 -(mensaje.Length/2)*6), Screen.height/2, 150, 300);

		if(flag){
			GUI.color = Color.red;
			
			GUI.Label(area, mensaje, style);
		}
	}

}

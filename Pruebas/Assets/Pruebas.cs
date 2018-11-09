using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pruebas : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        // Usando un string para parámetro
        if (Input.GetKeyDown("a"))
        {
            Debug.Log("Avanzar...");
        }
        // Usando un valor entero de la enumeracion KeyCode
        if (Input.GetKeyDown((KeyCode)323))
        {
            Debug.Log("Botón Izq Raton");
        }
        // Usando el valor del KeyCode
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            Debug.Log("Botón Der Raton");
        }
	}
}

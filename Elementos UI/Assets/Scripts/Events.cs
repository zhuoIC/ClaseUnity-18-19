using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Events : MonoBehaviour {
	public GameObject luz;
	public Text mensaje;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Saludame(){
		mensaje.text = "Hola soy el botón";
	}

	public void GoToScene(){
		SceneManager.LoadScene(2);
	}

	public void CambiarLuz(){
		luz.GetComponent<Light>().enabled = !luz.GetComponent<Light>().enabled;
	}
}

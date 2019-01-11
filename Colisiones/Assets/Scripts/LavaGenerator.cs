using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LavaGenerator : MonoBehaviour {
	public float upForce = 10f, torqueForce = 5f;
	private Rigidbody rigidbody;
	private bool flag = true;
	// Use this for initialization
	void Start () {
		rigidbody =  GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Space) && flag){
			Explosion();
			flag = false;
			Invoke("Crear", 1);
		}
	}

	void Explosion(){
		rigidbody.AddForce(Vector3.up * upForce, ForceMode.Impulse);
		rigidbody.AddForce(Vector3.right * Random.Range(-100,101)/100, ForceMode.Impulse);
		rigidbody.AddTorque(Vector3.one * torqueForce, ForceMode.Impulse);
	}

	void Crear(){
			Instantiate(this, new Vector3(0f, 0.25f,0f), new Quaternion());
			//Destroy(this.gameObject);	
			
			}

	void Desruir(){
			

	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour {
	public AudioSource audio;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(1.33f,1.33f,1.33f);
		if(Input.GetKeyDown(KeyCode.Space)){
			audio.Play();
			Destroy(gameObject);
		}
	}
}

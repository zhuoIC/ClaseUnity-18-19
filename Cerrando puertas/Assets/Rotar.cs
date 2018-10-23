using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotar : MonoBehaviour {
    private float _velocidad = 5f;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //transform.Rotate(Quaternion.Euler(0,1,0).eulerAngles);
        transform.RotateAround(Vector3.zero, Vector3.up, _velocidad *Time.deltaTime);
	}
}

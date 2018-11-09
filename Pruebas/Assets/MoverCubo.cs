using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverCubo : MonoBehaviour {

    public KeyCode arriba, abajo, izquierda, derecha;
    public float velocidad = 0.2F;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(arriba))
        {
            transform.Translate(transform.position.x, velocidad, transform.position.z);
        }
        if (Input.GetKey(abajo))
        {
            transform.Translate(transform.position.x, -velocidad, transform.position.z);
        }
        if (Input.GetKey(izquierda))
        {
            transform.Translate(transform.position.x, transform.position.y, velocidad);
        }
        if (Input.GetKey(derecha))
        {
            transform.Translate(transform.position.x, transform.position.y, velocidad);
        }
        transform.localScale.
    }
}

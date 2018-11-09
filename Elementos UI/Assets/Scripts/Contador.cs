using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Contador : MonoBehaviour {

    public Text text;
    float time;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        text.text = Time.time.ToString("0000");
	}
}

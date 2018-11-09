using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Areas : MonoBehaviour {
    public Transform _object;
    public Text _text;
    float i = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        i += Input.mouseScrollDelta.y;
        _text.text = i.ToString();
        _object.localScale = new Vector3(i, i, i);
	}
}

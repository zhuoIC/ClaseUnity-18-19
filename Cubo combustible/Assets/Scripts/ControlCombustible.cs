using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//------------------
using UnityEngine.UI;

public class ControlCombustible : MonoBehaviour {

	private float _incremento = 10;
	private Slider _slider;
	public static bool _combustible;
	// Use this for initialization
	void Start () {
		_combustible = true;
		_slider = GetComponent<Slider>();
	}
	
	// Update is called once per frame
	void Update () {
		// Aumento combustible con la A
		if(Input.GetKeyDown(KeyCode.A)){
			_slider.value += _incremento;
			_combustible = true;
		}
		if(Input.GetKeyDown(KeyCode.Z)){
			_slider.value -= _incremento;
			if(_slider.value == 0){
				_combustible = false;
			}
		}
	}
}

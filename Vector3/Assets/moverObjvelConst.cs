using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moverObjvelConst : MonoBehaviour {
	public Transform _moverObjvelConst;
	public Transform _destino;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.M)){
			_moverObjvelConst.position = Vector3.MoveTowards(_moverObjvelConst.position, _destino.position, 100);
		}
	}
}

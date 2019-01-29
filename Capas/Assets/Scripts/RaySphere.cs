using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RaySphere : MonoBehaviour {
	public Text txtInfo;
	public int mask =1 << 9;
	// Use this for initialization
	void Start () {
		
	}

	void FixedUpdate(){
		Vector3 origin = transform.position;
		Vector3 direction = Vector3.forward;
		float distance = Mathf.Infinity;
		RaycastHit info;
		Debug.DrawLine(origin,direction * 20,Color.blue);
		if(Physics.Raycast(origin, direction, out info,distance,mask)){
			txtInfo.text = "Objeto detectado: "+info.transform.name;
		}else{
			txtInfo.text = string.Empty;
		}
	}
}

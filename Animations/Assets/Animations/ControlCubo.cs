using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlCubo : MonoBehaviour {
	public Animator animator;
	public int speed = 0;

	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		animator.SetInteger("velocidad", speed);
	}
}

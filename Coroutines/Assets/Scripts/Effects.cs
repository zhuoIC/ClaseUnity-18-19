using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Effects : MonoBehaviour {
	Light light;
	// Use this for initialization
	void Start () {
		light = GameObject.Find("Directional Light").GetComponent<Light>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void initParpadeo(){
		StartCoroutine("Parpadeo");
		StartCoroutine("Cargar");
	}

	public void endParpadeo(){
		StopCoroutine("Parpadeo");
	}

	public void changeColor(){
		StartCoroutine("CambiaColor");
	}

	
	public void stopChangeColor(){
		StopCoroutine("CambiaColor");
	}

	IEnumerator Parpadeo(){
		int count = 20;
		while(true){
			for (int i = 0; i < count; i++)
			{
				light.enabled = !light.enabled;
				yield return new WaitForSeconds(Random.Range(0.25f,0.75f));
			}
			light.enabled = Random.Range(0,2) == 0;
			yield return new WaitForSeconds(3F);
		}
	}

	IEnumerator CambiaColor(){
		while(true){
			light.color = Color.Lerp(Color.red, Color.yellow, Mathf.PingPong(Time.time/2, 1));
			yield return null;
		}
	}

	IEnumerator Cargar(){
		WWW www = new WWW("https://michollo.com/wp-content/uploads/2019/02/whatisfcd-2019.jpg");
		yield return www;
		Texture2D texture = www.texture;
		GameObject.Find("RawImage").GetComponent<RawImage>().texture = texture;
	}
}

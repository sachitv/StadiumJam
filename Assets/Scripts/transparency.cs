using UnityEngine;
using System.Collections;

public class transparency : MonoBehaviour {
	float startY;
	public GameObject [] items;
	// Use this for initialization
	void Start () {
		startY = transform.position.y;
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(Vector3.forward * Input.GetAxis("Mouse ScrollWheel"));
		 
		for (int i =0; i<items.Length; ++i) 
		{
			Color a = items[i].renderer.material.color;
			a.a = (transform.position.y - startY + 2 ) / 2.0f;
			items[i].renderer.material.color = a;
		}

	}
}

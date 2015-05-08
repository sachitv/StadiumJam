using UnityEngine;
using System.Collections;

public class GiveSwag : MonoBehaviour {

	private GameObject Player;

	void Start()
	{
		Player = GameObject.Find("First Person Controller");
	}
	void OnTriggerEnter(Collider c)
	{
		Player.GetComponent<SwagHolder>().refillSwag();
	}
}

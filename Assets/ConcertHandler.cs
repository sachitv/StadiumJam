using UnityEngine;
using System.Collections;

public class ConcertHandler : MonoBehaviour {

	void OnTriggerEnter(Collider c)
	{
		Manager.Instance.isPlayerOnStage = true;
	}

	void OnTriggerExit(Collider c)
	{
		Manager.Instance.isPlayerOnStage = false;
	}
}

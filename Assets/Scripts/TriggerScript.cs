using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TriggerScript : MonoBehaviour {

	public string objectType;
	public GameObject UIHolder;
	private AudioHandler AudioManager;
	private double elapsedTime;

	// Use this for initialization
	void Start () {
		AudioManager = GameObject.Find("First Person Controller").GetComponent<AudioHandler>();
	}

	void Update()
	{
		elapsedTime += Time.deltaTime;
	}


	void OnTriggerStay(Collider c)
	{
		if(!UIHolder.activeSelf)
		{
			UIHolder.SetActive(true);

			UIHolder.GetComponent<Text>().text = "Press P to toggle "+objectType;
		}

		if(Input.GetKeyDown(KeyCode.P) && elapsedTime > 0.5) // To avoid spamming it.
		{
			AudioManager.toggleTrack(objectType);
			elapsedTime = 0;
		}
	}

	void OnTriggerExit(Collider c)
	{
		if(UIHolder.activeSelf)
		{
			UIHolder.SetActive(false);
		}
	}
}

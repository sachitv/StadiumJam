using UnityEngine;
using System.Collections;


public class AudienceHandler : MonoBehaviour {

	private AudioHandler AudioManager;
	private Animator anim;

	void Start()
	{
		AudioManager = GameObject.Find("First Person Controller").GetComponent<AudioHandler>();
		anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {

		if(Manager.Instance.isPlayerOnStage && !AudioManager.isSomethingPlaying())
		{
			anim.SetBool("shouldClap", true);
			anim.SetBool("shouldCelebrate", false);
		}

		else if(AudioManager.isSomethingPlaying())
		{
			anim.SetBool("shouldClap", false);
			anim.SetBool("shouldCelebrate", true);
		}

		else if(!Manager.Instance.isPlayerOnStage && !AudioManager.isSomethingPlaying())
		{
			anim.SetBool("shouldClap", false);
			anim.SetBool("shouldCelebrate", false);
		}
	
	}
}

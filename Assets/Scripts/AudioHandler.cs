using UnityEngine;
using System.Collections;

public class AudioHandler : MonoBehaviour {

	public AudioSource drumMusic;
	public AudioSource guitarMusic;
	public AudioSource bassMusic;
	public AudioSource pianoMusic;

	// Use this for initialization
	void Start () {
		AudioSource [] a = GetComponents<AudioSource>();

		drumMusic = a[0];
		guitarMusic = a[1];
		bassMusic = a[2];
		pianoMusic = a[3];
	
	}

	public void toggleTrack(string name)
	{
		if(name == "drums" && !drumMusic.isPlaying)
		{
			drumMusic.Play();
		}

		else if(name == "drums" && drumMusic.isPlaying)
		{
			drumMusic.Stop();
		}

		else if(name == "guitar" && !guitarMusic.isPlaying)
		{
			guitarMusic.Play();
		}

		else if(name == "guitar" && guitarMusic.isPlaying)
		{
			guitarMusic.Stop();
		}

		else if(name == "bass" && !bassMusic.isPlaying)
		{
			bassMusic.Play();
		}

		else if(name == "bass" && bassMusic.isPlaying)
		{
			bassMusic.Stop();
		}

		else if(name == "piano" && !pianoMusic.isPlaying)
		{
			pianoMusic.Play();
		}

		else if(name == "piano" && pianoMusic.isPlaying)
		{
			pianoMusic.Stop();
		}
	}

	public bool getPlayingStatus(string name)
	{
		if(name == "drums")
		{
			return drumMusic.isPlaying;
		}
		
		else if(name == "guitar")
		{
			return guitarMusic.isPlaying;
		}
		
		else if(name == "bass")
		{
			return bassMusic.isPlaying;
		}
		
		else if(name == "piano")
		{
			return pianoMusic.isPlaying;
		}

		return false;
	}

	public bool isSomethingPlaying()
	{
		if(drumMusic.isPlaying || guitarMusic.isPlaying || bassMusic.isPlaying || pianoMusic.isPlaying)
		{
			return true;
		}
		return false;
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointAudio : MonoBehaviour {

	private AudioSource audio;

	// Use this for initialization
	void Start () {
		audio = GetComponent<AudioSource> ();	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void PlayAudio () {
		audio.Play ();
	}

	public void PauseAudio () {
		audio.Pause ();
	}
}

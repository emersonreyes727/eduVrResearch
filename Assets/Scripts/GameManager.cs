using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class GameManager : MonoBehaviour {

	[SerializeField] private VideoPlayer projector;
	[SerializeField] private VideoPlayer pc;
	[SerializeField] private VideoPlayer table;

	public GameObject startUi;
	public GameObject endUi;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void PlayProjector () {
		projector.Play ();
	}

	public void PauseProjector () {
		projector.Pause ();
	}

	public void PlayPC () {
		pc.Play ();
	}

	public void PausePC () {
		pc.Pause ();
	}

	public void PlayTable () {
		table.Play ();
	}

	public void PauseTable () {
		table.Pause ();
	}

	public void closeStartUi () {
		startUi.SetActive(false);
		endUi.SetActive(true);
	}

	public void endApp () {
		Application.Quit ();
	}
}

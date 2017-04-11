using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPosition : MonoBehaviour {

	public GameObject waypointOne;
	public GameObject waypointTwo;
	public GameObject waypointThree;
	public GameObject waypointFour;
	public GameObject waypointFive;
	public GameObject waypointSix;

	private AudioSource audio;

	public float height = 0.80f;

	// Use this for initialization
	void Start () {
		audio = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void WaypointOne () {
		Vector3 newPosition = new Vector3 (waypointOne.transform.position.x, waypointOne.transform.position.y + height, waypointOne.transform.position.z);
		transform.position = newPosition;
		audio.Play ();

		waypointOne.SetActive(false);
		waypointTwo.SetActive(true);
		waypointThree.SetActive(true);
		waypointFour.SetActive(true);
		waypointFive.SetActive(true);
		waypointSix.SetActive(true);
	}

	public void WaypointTwo () {
		Vector3 newPosition = new Vector3 (waypointTwo.transform.position.x, waypointTwo.transform.position.y + height, waypointTwo.transform.position.z);
		transform.position = newPosition;
		audio.Play ();

		waypointOne.SetActive(true);
		waypointTwo.SetActive(false);
		waypointThree.SetActive(true);
		waypointFour.SetActive(true);
		waypointFive.SetActive(true);
		waypointSix.SetActive(true);
	}

	public void WaypointThree () {
		Vector3 newPosition = new Vector3 (waypointThree.transform.position.x, waypointThree.transform.position.y + height, waypointThree.transform.position.z);
		transform.position = newPosition;
		audio.Play ();

		waypointOne.SetActive(true);
		waypointTwo.SetActive(true);
		waypointThree.SetActive(false);
		waypointFour.SetActive(true);
		waypointFive.SetActive(true);
		waypointSix.SetActive(true);
	}

	public void WaypointFour () {
		Vector3 newPosition = new Vector3 (waypointFour.transform.position.x, waypointFour.transform.position.y + height, waypointFour.transform.position.z);
		transform.position = newPosition;
		audio.Play ();

		waypointOne.SetActive(true);
		waypointTwo.SetActive(true);
		waypointThree.SetActive(true);
		waypointFour.SetActive(false);
		waypointFive.SetActive(true);
		waypointSix.SetActive(true);
	}

	public void WaypointFive () {
		Vector3 newPosition = new Vector3 (waypointFive.transform.position.x, waypointFive.transform.position.y + height, waypointFive.transform.position.z);
		transform.position = newPosition;
		audio.Play ();

		waypointOne.SetActive(true);
		waypointTwo.SetActive(true);
		waypointThree.SetActive(true);
		waypointFour.SetActive(true);
		waypointFive.SetActive(false);
		waypointSix.SetActive(true);
	}

	public void WaypointSix () {
		Vector3 newPosition = new Vector3 (waypointSix.transform.position.x, waypointSix.transform.position.y + height, waypointSix.transform.position.z);
		transform.position = newPosition;
		audio.Play ();

		waypointOne.SetActive(true);
		waypointTwo.SetActive(true);
		waypointThree.SetActive(true);
		waypointFour.SetActive(true);
		waypointFive.SetActive(true);
		waypointSix.SetActive(false);
	}
}

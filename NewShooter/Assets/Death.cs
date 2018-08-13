using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour {
	public Transform destination;
	public AudioClip clip;

	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player") {
			AudioSource.PlayClipAtPoint (clip, transform.position);
			other.transform.position = destination.position;
		}
	}

}

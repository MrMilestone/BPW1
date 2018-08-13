using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boundaries : MonoBehaviour {

	public Transform destination1;
	public Transform destination2;
	public Transform destination3;
	public AudioClip clip1;

		

	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Correct") {
			AudioSource.PlayClipAtPoint (clip1, transform.position);
			other.transform.position = destination3.position;
			Rigidbody rb = other.gameObject.GetComponent<Rigidbody>();
			rb.velocity = Vector2.zero;


		} else if (other.tag == "Incorrect1") 
		{
			AudioSource.PlayClipAtPoint (clip1, transform.position);
			other.transform.position = destination1.position;
			Rigidbody rb = other.gameObject.GetComponent<Rigidbody>();
			rb.velocity = Vector2.zero;
		}
		else if (other.tag == "Incorrect2") 
		{
			AudioSource.PlayClipAtPoint (clip1, transform.position);
			other.transform.position = destination2.position;
			Rigidbody rb = other.gameObject.GetComponent<Rigidbody>();
			rb.velocity = Vector2.zero;

		}

	}
}

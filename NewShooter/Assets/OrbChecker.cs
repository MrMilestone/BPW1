
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
	[RequireComponent(typeof(AudioSource))]
	[RequireComponent(typeof(AudioSource))]

	public class OrbChecker : MonoBehaviour
	{
		public GameObject Door;
		public Transform destination;
		public Transform destination1;
		public Transform destination2;
		public AudioClip clip1;
		public AudioClip clip2;
	void Start(){
		Door = GameObject.FindGameObjectWithTag ("Door");
	}


		void OnTriggerEnter(Collider other)
		{
		if (other.tag == "Correct") {
			AudioSource.PlayClipAtPoint (clip1, transform.position);
			Door.transform.position = destination.position;
			Destroy(other.gameObject);
			Destroy(GameObject.Find("Orbtester"));



		} else if (other.tag == "Incorrect1") 
		{
			AudioSource.PlayClipAtPoint (clip2, transform.position);
			other.transform.position = destination1.position;
			Rigidbody rb = other.gameObject.GetComponent<Rigidbody>();
			rb.velocity = Vector2.zero;
		}
		else if (other.tag == "Incorrect2") 
		{
			AudioSource.PlayClipAtPoint (clip2, transform.position);
			other.transform.position = destination2.position;
			Rigidbody rb = other.gameObject.GetComponent<Rigidbody>();
			rb.velocity = Vector2.zero;

		}

		}
	}


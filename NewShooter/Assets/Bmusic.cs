using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bmusic : MonoBehaviour {
	public AudioClip clip;
	// Use this for initialization
	void Start () {
		AudioSource.PlayClipAtPoint(clip, transform.position);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

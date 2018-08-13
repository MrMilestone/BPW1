using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour 
{
	public GameObject bulletPrefab;
	//public GameObject CasePrefab;


	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{

		if (Input.GetMouseButtonDown (0)) 
		{
			//GameObject Case = Instantiate (CasePrefab, transform.position + transform.forward, Quaternion.identity);
			GameObject bullet = Instantiate (bulletPrefab, transform.position + transform.forward, Quaternion.identity);
			Rigidbody rigidbody = (Rigidbody)bullet.GetComponent (typeof(Rigidbody)); 



			rigidbody.AddForce (transform.forward * 1400);


		}
		if (Input.GetMouseButtonDown (1)) 
		{
			RaycastHit hitinfo; 
			if (Physics.Raycast (transform.position + transform.forward, transform.forward, out hitinfo)) 
			{
				if (hitinfo.collider.gameObject.name == "Target") 
				{
					//rigidbody.AddForce (transform.up * 500);
					//Destroy (hitinfo.collider.gameObject);
				}
			}
		}
	}
}

using UnityEngine;
using System.Collections;
using System.Diagnostics;
using System;
using System.IO;
using Random=UnityEngine.Random;


public class Attack : MonoBehaviour {
	// Use this for initialization
	//private rigidbody rb;
	CreateSphere cs = new CreateSphere();
	string currentEvent;
	void Start () {
		transform.localEulerAngles = new Vector3 (0, -180, -180);


	}
	void OnCollisionEnter (Collision Red){
		if (Red.collider.name == "Sp1") // In this part check if the Object collision is as same as new created Object
		{
			
			Red.gameObject.SetActive (false);
				//gameObject newSphere = cs.CreateSph ();
			cs.CreateSph (); // call to create new sphere to create it here
		} 
		if (Red.collider.name == "Sp1") {
			Red.gameObject.SetActive (false);
		}
		if (Red.collider.name == "Red") {
			Red.gameObject.SetActive (false);
		}
		if (Red.collider.name == "RedOne") {
			Red.gameObject.SetActive (false);
		}
		if (Red.collider.name == "RedSecond") {
			Red.gameObject.SetActive (false);
		} 
		}

	// Update is called once per frame
	void Update(){	
		transform.localEulerAngles = new Vector3 (0, -180, -180);
//
//		currentEvent = " ; "  + gameObject.name +
//			" ; " + gameObject.transform.position.x / 100 +
//			" ; " + gameObject.transform.position.y / 100 +
//			" ; " + gameObject.transform.position.z / 100 +
//			" ; " + gameObject.transform.rotation.x +
//			" ; " + gameObject.transform.rotation.y +
//			" ; " + gameObject.transform.rotation.z +
//			" ; " + gameObject.GetComponent<Rigidbody> ().velocity.magnitude;

	}
		
}
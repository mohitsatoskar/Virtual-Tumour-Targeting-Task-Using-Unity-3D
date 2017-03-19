using UnityEngine;
using System.Collections;

public class CreateSphere : MonoBehaviour {
	
	string currentEvent;
	// Use this for initialization
	void Start () {
		Dbg.TraceWithOutTimeStampe ("TimeStamp ; Caustive Object ; Caustive Object Position X ; Caustive Object Position Y ; Caustive Object Position Z ; Caustive Object Rotation X ; Caustive Object Rotation Y ; Caustive Object Rotation Z ; Distance ; Receptive Object Name ; Receptive Object Position X ; Receptive Object Position Y ; Receptive Object Position Z ; Receptive Object Rotation X ; Receptive Object Rotation Y ; Receptive Object Rotation Z ; Distance ; Incidence Angle ; Receptive Object Width ; Sesion Elapsed Time ;");

		CreateSph ();
	}
	public void CreateSph(){

		//int count = 0;
	//	while (count < 6) {
			GameObject SphereSmall = GameObject.CreatePrimitive (PrimitiveType.Sphere);// It creates a Sphere through CreatePrimitive  and the type is SPhere
			//SphereSmall.transform.localScale = new Vector3 (5, 5, 5);
		    SphereSmall.transform.localScale += new Vector3 (3,3,3);
			SphereSmall.name = "Sp1"; // name of the circule created
			SphereSmall.transform.position = new Vector3 ();// the position of new object as a vector
			SphereSmall.transform.position = Random.insideUnitSphere * 5; // Change the position to random positions

		currentEvent = " ; " + SphereSmall.name +
			" ; " + SphereSmall.transform.position.x / 100 +
			" ; " + SphereSmall.transform.position.y / 100 +
			" ; " + SphereSmall.transform.position.z / 100 +
			" ; " + SphereSmall.transform.rotation.x +
			" ; " + SphereSmall.transform.rotation.y +
			" ; " + SphereSmall.transform.rotation.z;
		Dbg.TraceWithTimeStamp(currentEvent);

			transform.position = new Vector3(Random.Range(5, 5), Random.Range(5, 5), Random.Range(5, 5)); //this line is for setting the White
		//SPhere position to be inside the Green Sphere
			SphereSmall.transform.localScale = new Vector3 (2, 2, 2);//this one is for scale of white circule
		//	count++;
	//	}
//		currentEvent = " ; " + SphereSmall.name +
//			" ; " + SphereSmall.transform.position.x / 100 +
//			" ; " + SphereSmall.transform.position.y / 100 +
//			" ; " + SphereSmall.transform.position.z / 100 +
//			" ; " + SphereSmall.transform.rotation.x +
//			" ; " + SphereSmall.transform.rotation.y +
//			" ; " + SphereSmall.transform.rotation.z;
//			Dbg.TraceWithTimeStamp(currentEvent);
	}

	
	// Update is called once per frame
	void Update () {
		//CreateSph ();


	}
}

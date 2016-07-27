using UnityEngine;
using System.Collections;

public class FireObject : MonoBehaviour {

	public Vector3 speed;
	private Rigidbody rb;

	void Start (){
		rb = GetComponent <Rigidbody> ();
		rb.velocity = speed;
	}
}

using UnityEngine;
using System.Collections;

public class Mover : MonoBehaviour {

	public Vector3 score;
	public Rigidbody rb;

	void Update (){
		rb = GetComponent <Rigidbody> ();
		rb.velocity = score;
	}
}

using UnityEngine;
using System.Collections;

public class Jump : MonoBehaviour {

	public Rigidbody redRB;
	public Vector3 force;

	void Start (){
		redRB = GetComponent<Rigidbody> ();
	}

	void Update () {
		if (Input.GetKeyDown ("space")) {
			redRB.velocity = force;
		}
	}
}

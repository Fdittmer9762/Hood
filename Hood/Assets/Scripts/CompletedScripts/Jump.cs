using UnityEngine;
using System.Collections;

public class Jump : MonoBehaviour {

	public Rigidbody redRB;
	public Vector3 force;
	public Animator redAnim;

	void Start (){
		redRB = GetComponent<Rigidbody> ();
		redAnim = GetComponent<Animator> ();
	}

	void Update () {
	//void OnMouseDown (){
		if (Input.GetKeyDown ("space")) {
			redRB.velocity = force;
			redAnim.SetTrigger("Jumping");//play jumping animation
		Debug.Log ("jump"); //debug
		}
	}
}

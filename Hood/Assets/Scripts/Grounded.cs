using UnityEngine;
using System.Collections;

public class Grounded : MonoBehaviour {

	public Animator redAnim;

	void Start (){
		redAnim = GetComponent<Animator> ();
	}

	void OnTriggerEnter() {
		redAnim.SetTrigger ("Grounded");
		Debug.Log ("landing");
	}
}

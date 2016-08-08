using UnityEngine;
using System.Collections;

public class Explode : MonoBehaviour {

	public Collider obsCollider;

	void Start (){
		obsCollider = GetComponent<Collider> ();
	}

	void OnTriggerEnter(){ //attach to the Obs
			//set anim to explode
		obsCollider.enabled=false;//deactivate player detector
		Debug.Log ("Hit Bolt");
	}
}
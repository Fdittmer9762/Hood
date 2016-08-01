using UnityEngine;
using System.Collections;

public class Boundary : MonoBehaviour {

	void OnTriggerExit (Collider other){
		//destroys objects that leave the boundarys
		//Destroy (other.gameObject);
		other.gameObject.SetActive (false);
	}

}

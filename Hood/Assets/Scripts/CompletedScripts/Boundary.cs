using UnityEngine;
using System.Collections;

public class Boundary : MonoBehaviour {

	void OnTriggerExit (Collider other){
		other.gameObject.SetActive (false); //destroys objects that leave the boundarys
		//need to destroy object
	}

}

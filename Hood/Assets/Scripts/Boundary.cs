using UnityEngine;
using System.Collections;

public class Boundary : MonoBehaviour {

	void OnColliderEnter (Collider other){
		//destroys objects that leave the boundarys
		DestroyObject (other.gameObject);
	}

}

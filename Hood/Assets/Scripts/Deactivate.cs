using UnityEngine;
using System.Collections;

public class Deactivate : MonoBehaviour {

	void Start(){
		this.gameObject.SetActive (true);
	}

	public void OnColliderEnter(){
		this.gameObject.SetActive (false);
	}

}

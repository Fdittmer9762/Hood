using UnityEngine;
using System.Collections;

public class Deactivate : MonoBehaviour {

	void Start(){
		this.gameObject.SetActive (true);
	}

	public void OnTriggerEnter(){
		this.gameObject.SetActive (false);
	}

}

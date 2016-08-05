using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour {

	public float waitTime =.1f;
	public GameObject bolt;
	public Transform boltSpawn;

	void Fire(){ //use for testing until animation is added
		Debug.Log ("fire!");//debugging
		Instantiate(bolt, boltSpawn.position, Quaternion.identity);
	}

	IEnumerator Attack () {
		//call attack animation, will add later
		yield return new WaitForSeconds(waitTime); 	//wait for time allows animation to align
		Debug.Log ("fire!");//debugging
		Instantiate(bolt, boltSpawn.position, Quaternion.identity); //spawn firebolt
	}

	void OnMouseDown(){//can be placed on a fire buttton or on the player
		Fire(); //replace with coroutine later
	}

}

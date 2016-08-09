using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour {

	public float waitTime =.5f;
	public GameObject bolt;
	public Transform boltSpawn;
	public Animator redAnim;

	void Start(){
		redAnim = GetComponent<Animator>();
	}

	IEnumerator Attack () {
		redAnim.SetTrigger ("Attacking");//call attack animation,
		yield return new WaitForSeconds(waitTime); 	//wait for time allows animation to align
		//Debug.Log ("fire!");//debugging
		Instantiate(bolt, boltSpawn.position, Quaternion.identity); //spawn firebolt
	}

	void OnMouseDown(){//can be placed on a fire buttton or on the player
		StartCoroutine (Attack());//fires bolt and plays attack
	}

}

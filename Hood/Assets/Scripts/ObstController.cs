using UnityEngine;
using System.Collections;

public class ObstController : MonoBehaviour {

	IEnumerator TimeDelay (int time) {
		yield return new WaitForSeconds(time);
	}
	//had to take it from the delay script, wasn't able to implament it from there, try to fix later

	void OnTriggerEnter (Collider other) {
		if (other.tag == "Player") {
			RedStates.currentRedState = RedStates.redState.Damage;//damage player
			//Debug.Log ("PlayerHit"); //for debugging
			//**death and game over are called through the player**
		}
		if (other.tag == "Bolt") {
			ObstState.currentObstacleState = ObstState.obstacleState.exploding; //set state to explode
			Debug.Log ("bolt");
			//this.collider.setactive (false); //disable the collider, so it dosent kill the player after being destroyed, having issues
			//play explosion and let it automatically go to the smoldering animation
			//add points to score, still need to add to game controller
			//ObstState.currentObstacleState = ObstState.obstacleState.destroyed; //set state to destroyed, may no longer need
		}
	}
}

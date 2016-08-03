using UnityEngine;
using System.Collections;

public class ObstController : MonoBehaviour {

	public int explosionTime;

	IEnumerator TimeDelay (int time) {
		yield return new WaitForSeconds(time);
	}
	//had to take it from the delay script, wasn't able to implament it from there, try to fix later

	void OnTriggerEnter (Collider other) {
		if (other.tag == "Player") {
			RedStates.currentRedState = RedStates.redState.Damage;//damage player
			Debug.Log ("PlayerHit");
			//stop the world from moving, still need to figure that out
			//GameStates.currentGameState= GameStates.gameState.GameOver;	//**called through the player**
		}
		if (other.tag == "Bolt") {
			ObstState.currentObstacleState = ObstState.obstacleState.exploding; //set state to explode
			TimeDelay (explosionTime);	//let animation run, try to use coroutine
			ObstState.currentObstacleState = ObstState.obstacleState.destroyed; //set state to destroyed
		}
	}

	void Update (){
		
	}
}

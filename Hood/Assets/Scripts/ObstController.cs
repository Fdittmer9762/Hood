using UnityEngine;
using System.Collections;

public class ObstController : MonoBehaviour {

	public int explosionTime;

	IEnumerator TimeDelay (int time) {
		yield return new WaitForSeconds(time);
	}
	//had to take it from the delay script, wasn't able to implament it from there, try to fix later

	void OnTriggerEnter (GameObject other) {
		/*if (other.tag == Player) {
			//set player state to death
			RedStates.currentRedState = RedStates.redState.Death;
			//stop the world from moving, still need to figure that out
			//change game state to game over
			GameStates.currentGameState= GameStates.gameState.GameOver;
		}
		if (other.tag == Bolt) {
			//set state to explode
			ObstState.currentObstacleState = ObstState.obstacleState.exploding;
			//let animation run, try to use coroutine
			TimeDelay (explosionTime);
			//set state to destroyed
			ObstState.currentObstacleState = ObstState.obstacleState.destroyed;
		}*/
	}
		//**deleted** handled by boundary script
}

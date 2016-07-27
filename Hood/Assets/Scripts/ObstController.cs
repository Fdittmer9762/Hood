using UnityEngine;
using System.Collections;

public class ObstController : MonoBehaviour {

	public int explosionTime;

	void OnColliderEnter (Collider other) {
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
			Delay.TimeDelay(explosionTime);
			//set state to destroyed
			ObstState.currentObstacleState = ObstState.obstacleState.destroyed;
		}
		if (other.tag == Boundary) {
			//destroy itself, or set to inactive. whatever is more efficent. inactive may cause mem leak
		}*/
	}

	/*void OncolliderExit (Collider other) {
		//when the boandary is exited destroy the object
	}*/

	//   **deciding on the best way to handle it, keeping code just in case**
	//   **may consider replacing if statements with an array and switch statement, will try later**
}

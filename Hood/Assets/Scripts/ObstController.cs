using UnityEngine;
using System.Collections;

public class ObstController : MonoBehaviour {

	void OnColliderEnter (Collider other) {
		if (other.tag == Player) {
			//set player state to death
			//stop the world from moving
			//change game state to game over
		}
		if (other.tag == Bolt) {
			//set state to explode
			//let animation run
			//set state to destroyed
		}
		if (other.tag == Boundary) {
			//destroy itself
		}
	}

	/*void OncolliderExit (Collider other) {
		//when the boandary is exited destroy the object
	}*/

	//   **deciding on the best way to handle it, keeping code just in case**
	//   **may consider replacing if statements with an array and switch statement, will try later**
}

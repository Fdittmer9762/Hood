using UnityEngine;
using System.Collections;

public class RedController : MonoBehaviour {

	public int health;
	
	// Update is called once per frame
	void Update () {
		switch (RedStates.currentRedState) {
		case RedStates.redState.Jumping:
			//
			break;
		case RedStates.redState.Falling:
			//
			break;
		case RedStates.redState.Landing:
			//
			break;
		case RedStates.redState.Attacking:
			//
			break;
		case RedStates.redState.Damage:
			if (health < 0) {
				print ("Health: " + health);
			} else {
				RedStates.currentRedState = RedStates.redState.Death;
				GameStates.currentGameState = GameStates.gameState.GameOver;
				//this.gameObject.SetActive (false);  killing the player, will use different method
			}
			RedStates.currentRedState = RedStates.redState.Running;
			break;
		case RedStates.redState.Death:
			GameStates.currentGameState = GameStates.gameState.GameOver;
			break;
		}
	}
}

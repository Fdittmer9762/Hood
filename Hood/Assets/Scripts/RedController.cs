using UnityEngine;
using System.Collections;

public class RedController : MonoBehaviour {

	public int health;

	void Update () {
		switch (RedStates.currentRedState) {
		case RedStates.redState.Running:
			//default state, play the running animation
			break;
		case RedStates.redState.Jumping:
			//while the state is jump (player is holding jump) move the player up
			//when the height reaches the limit switch to falling
			break;
		case RedStates.redState.Falling:
			//fall unitl player reaches the ground,
			break;
		case RedStates.redState.Landing:
			//stop player from falling, set redstate to landing, 
			break;
		case RedStates.redState.Attacking:
			//attack coroutine, using coroutine due to waitfor and other benifits
			//attack coruotine: start attack animation, wait for x time, spawn fire bolt, 
			//after coroutine set animation 
			break;
		case RedStates.redState.Damage:
			//decrement health, check health, if health is gone kill player
			if (health < 0) {
				health--;
				print ("Health: " + health); //to check functionallity, will replace with gui
				RedStates.currentRedState = RedStates.redState.Running;
			} else {
				RedStates.currentRedState = RedStates.redState.Death;
			}
			break;
		case RedStates.redState.Death:
			GameStates.currentGameState = GameStates.gameState.GameOver;
			break;
		}
	}
}

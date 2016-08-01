using UnityEngine;
using System.Collections;

public class RedController : MonoBehaviour {

	public Vector3 redPosition;
	public GameObject bolt;
	public Transform boltSpawn;
	public int health;
	public float waitTime = .1f;

	IEnumerator Attack () {
		//call attack animation, will add later
		//wait for time allows animation to align
		yield return new WaitForSeconds(waitTime);
		//spawn firebolt, should work, not sure what the issue is...
		//Instantiate (bolt, boltSpawn.position, boltSpawn.transform);
		//set state to running
	}

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
			//attack coroutine
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
		default:
			RedStates.currentRedState = RedStates.redState.Running;
			break;
		}
	}
}

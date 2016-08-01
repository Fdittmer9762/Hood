using UnityEngine;
using System.Collections;

public class RedController : MonoBehaviour {

	public Transform redPosition;
	public int health;

	public GameObject bolt;
	public Transform boltSpawn;
	public float waitTime = .1f;

	public float jump;
	public float jumpLimit = 2f;
	bool jumpPress = Input.GetKey("Jump");
	bool jumpHeld= Input.GetKey("Jump");

	IEnumerator Attack () {
		//call attack animation, will add later
		yield return new WaitForSeconds(waitTime); 	//wait for time allows animation to align
		Instantiate (bolt, boltSpawn.position, boltSpawn.transform); //spawn firebolt, should work, not sure what the issue is...
		//RedStates.currentRedState= RedStates.redState.Running; //set state to running
	}

	void OnMouseDown (){
		//use for testing states, for now
	}

	void Update () {
		switch (RedStates.currentRedState) {
		case RedStates.redState.Running:
			//default state, play the running animation
			break;
		case RedStates.redState.Jumping:
			while (jumpPress == true /*&& player height is less than */ ){ 	//while the state is jump (player is holding jump) move the player up
				//move player up
			}
			RedStates.currentRedState = RedStates.redState.Falling; //when the height reaches the limit switch to falling
			break;
		case RedStates.redState.Falling:
			//play animation for falling
			if (/*player hits the ground, stops moving down*/) {
				RedStates.currentRedState = RedStates.redState.Landing; //change to landing
			}
			break;
		case RedStates.redState.Landing:
			//stop player from falling, set redstate to landing, 
			//play landing animation
			//set state to running after anim has finished
			break;
		case RedStates.redState.Attacking:
			StartCoroutine("Attack"); //attack coroutine
			break;
		case RedStates.redState.Damage: //decrement health, check health, if health is gone kill player
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

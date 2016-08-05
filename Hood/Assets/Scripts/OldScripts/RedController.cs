using UnityEngine;
using System.Collections;

public class RedController : MonoBehaviour {

	public Rigidbody redRB;
	public int health = 3;

	public GameObject bolt;
	public Transform boltSpawn;
	public float waitTime = .1f;

	public float jumpForce= .1f;
	public float jumpLimit = 2f;
	bool jumpPress = Input.GetKey("Jump");
	//bool jumpHeld= Input.GetKey("Jump");

	void start (){
		redRB = GetComponent<Rigidbody> ();
	}

	void Fire(){ //use for testing until animation is added
		Debug.Log ("fire!");//debugging
		Instantiate(bolt, boltSpawn.position, Quaternion.identity);
	}

	IEnumerator Attack () {
		//call attack animation, will add later
		yield return new WaitForSeconds(waitTime); 	//wait for time allows animation to align
		//Instantiate (bolt, boltSpawn.position, boltSpawn.transform); //spawn firebolt, should work, not sure what the issue is...
		//RedStates.currentRedState= RedStates.redState.Running; //set state to running
	}

	void OnMouseDown (){
		//use for testing states, for now
		Fire();
	}

	void Update () {
		switch (RedStates.currentRedState) {
		case RedStates.redState.Running:
			//default state, play the running animation
			break;
		case RedStates.redState.Jumping:
			
			RedStates.currentRedState = RedStates.redState.Falling; //when the height reaches the limit switch to falling
			break;
		case RedStates.redState.Falling:
			//reworking
			break;
		case RedStates.redState.Landing://may want to rework into a coroutine
			//stop player from falling, may no longer need
			//play landing animation
			RedStates.currentRedState = RedStates.redState.Running; //set state to running after anim has finished
			break;
		case RedStates.redState.Attacking:
			StartCoroutine("Attack"); //attack coroutine
			break;
		case RedStates.redState.Damage: //decrement health, check health, if health is gone kill player
			if (health > 1) {
				health--;
				Debug.Log ("Health: " + health); //to check functionallity, will replace with gui
				RedStates.currentRedState = RedStates.redState.Running;
			} else {
				RedStates.currentRedState = RedStates.redState.Death;
			}
			break;
		case RedStates.redState.Death:
			GameStates.currentGameState = GameStates.gameState.GameOver;
			Debug.Log ("Ashes to ashes");// for debuging
			//play death animation
			this.gameObject.SetActive (false); //destroy the player, remove later
			break;
		default:
			RedStates.currentRedState = RedStates.redState.Running;
			Debug.Log("default"); //used for debuging, remove later
			break;
		}
	}
}


//case RedStates.redState.Jumping:
//while (jumpPress == true /*&& player height is less than the jump limit */ ){ 	//while the state is jump (player is holding jump) move the player up
//	redRB.AddForce(transform.forward * jumpForce); //move player up
//}
//RedStates.currentRedState = RedStates.redState.Falling; //when the height reaches the limit switch to falling
//break;
//case RedStates.redState.Falling:
//play animation for falling, falling will be handled by the rigidbody
/*if (/*player hits the ground, stops moving down) {
//				RedStates.currentRedState = RedStates.redState.Landing; //change to landing
//			}*/
//break;
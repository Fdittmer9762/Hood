using UnityEngine;
using System.Collections;

public class DamPlayer : MonoBehaviour {

	public int health;

	void DammagePlayer ()
	{
		Debug.Log ("PlayerHit");//for debugging
		health--;
		if (health > 0) {
			Debug.Log ("Health: " + health);
			//to check functionallity, will replace with gui
		}
		else {
			GameStates.currentGameState = GameStates.gameState.GameOver;
			Debug.Log ("Ashes to ashes");// for debuging
			//play death animation
			transform.parent.gameObject.SetActive(false);
			//this.gameObject.SetActive (false);
			//destroy the player, remove later
		}
	}

	void OnTriggerEnter (Collider other) {// when obs/enemy enters
		DammagePlayer (); 
	}
		
}
using UnityEngine;
using System.Collections;

public class DamPlayer : MonoBehaviour {

	public int health;

	void OnTriggerEnter (Collider other) {// when obs/enemy enters
		Debug.Log ("PlayerHit"); //for debugging
		if(health > 1){
			Debug.Log ("Health: " + health); //to check functionallity, will replace with gui
		} else {
			GameStates.currentGameState = GameStates.gameState.GameOver;
			Debug.Log ("Ashes to ashes");// for debuging
			//play death animation
			this.gameObject.SetActive (false); //destroy the player, remove later
		}
	}
}
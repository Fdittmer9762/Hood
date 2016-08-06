using UnityEngine;
using System.Collections;

public class PlayerBound : MonoBehaviour {

	void OnTriggerExit(){//needs to be on player detecting layer
		GameStates.currentGameState = GameStates.gameState.GameOver;//Call Game Over Screen
		Debug.Log ("Game Over");//debugging
	}
}

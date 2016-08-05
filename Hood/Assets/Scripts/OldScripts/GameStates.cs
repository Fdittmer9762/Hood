using UnityEngine;
using System.Collections;

public class GameStates : MonoBehaviour {

	public enum gameState {Loading, Starting, Playing, GameOver, End};

	public static gameState currentGameState;

}

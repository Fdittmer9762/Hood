using UnityEngine;
using System.Collections;

public class GameStates : MonoBehaviour {

	public enum gameState {Loading, Starting, Playing, End};

	public gameState currentGameState;

}

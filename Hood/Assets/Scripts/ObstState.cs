using UnityEngine;
using System.Collections;

public class ObstState : MonoBehaviour {

	public enum obstacleState {inactive, exploding, destroyed, kill};

	public obstacleState currentObstacleState = obstacleState.inactive;
}

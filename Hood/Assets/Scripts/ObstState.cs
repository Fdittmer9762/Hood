using UnityEngine;
using System.Collections;

public class ObstState : MonoBehaviour {

	public enum obstacleState {inactive, exploding, destroyed, kill};

	public static obstacleState currentObstacleState = obstacleState.inactive;
}

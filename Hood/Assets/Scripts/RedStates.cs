using UnityEngine;
using System.Collections;

public class RedStates : MonoBehaviour {

	public enum redState {Running, Jumping, Falling, Landing, Attacking, Death};

	public static redState currentRedState = redState.Running;

}

using UnityEngine;
using System.Collections;

public class RedStates : MonoBehaviour {

	public enum redState {Running, Jumping, Falling, Landing, Attacking, Damage, Death}; //still need anim for death

	public static redState currentRedState = redState.Running;

}

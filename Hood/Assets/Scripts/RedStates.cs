using UnityEngine;
using System.Collections;

public class RedStates : MonoBehaviour {

	public enum redState {Running, Jumping, Landing, Attacking, Death};

	public redState currentRedState;

}

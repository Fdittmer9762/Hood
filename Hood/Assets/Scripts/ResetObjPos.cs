using UnityEngine;
using System.Collections;

public class ResetObjPos : MonoBehaviour {

	public Transform currentPos;// transform of object
	public Transform startingTransform; //transform of object spawner
	//public float resetTime;

	/*  Method 1
	IEnumerator Countdown () {
		yield return new WaitForSeconds (resetTime);
		currentPos = startingTransform; 
	}

	void Start () {
		StartCoroutine("Countdown");
	}
	*/

	public void ResetPos(){
		currentPos = startingTransform;
	}
}

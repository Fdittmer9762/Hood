using UnityEngine;
using System.Collections;

public class Delay : MonoBehaviour {

	public IEnumerator TimeDelay (int time) {
		yield return new WaitForSeconds(time);
		//break;
	}
}

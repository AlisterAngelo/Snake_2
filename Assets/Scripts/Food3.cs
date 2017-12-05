using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food3 : MonoBehaviour {

	void OnTriggerEnter (Collider other) {
		if (other.CompareTag ("SnakeMain")) {
			other.GetComponent<SnakeMovement> ().SpeedDown ();
			Destroy (gameObject);
		}
	}
}

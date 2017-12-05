using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TailMovement : MonoBehaviour {

	public float Speed;
	public Vector3 tailTarget;
	public SnakeMovement mainSnake;
	public GameObject tailTargetObj;
	public int indx;

	void Start () {
		mainSnake = GameObject.FindWithTag ("SnakeMain").GetComponent<SnakeMovement> ();
		Speed = mainSnake.Speed+6f;

        if (mainSnake.tailParts.Count <= 1)
        {
            tailTargetObj = GameObject.FindWithTag("SnakeMain");
        }
        else
        {
            tailTargetObj = mainSnake.tailParts[mainSnake.tailParts.Count - 2];
        }

        indx = mainSnake.tailParts.IndexOf (gameObject);
	}

	void Update(){
		tailTarget = tailTargetObj.transform.position;
        transform.LookAt(tailTarget);
        transform.position = Vector3.Lerp (transform.position, tailTarget, Time.deltaTime * Speed);
	}

	void OnTriggerEnter(Collider other) {
		if (other.CompareTag ("SnakeMain")) {
			if (indx > 2) {
				Application.LoadLevel (Application.loadedLevel);
			}
		}
	}
}

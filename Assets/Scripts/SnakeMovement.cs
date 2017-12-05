using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SnakeMovement : MonoBehaviour {

	public float Speed = 4;
	public float RotationSpeed;
	public List<GameObject> tailParts = new List<GameObject>();
	public float Z_offset = 1f;
	public GameObject tailPrefab;
	public Text ScoreText;
	public int score = 1;
    public Vector3 newTailPos;

    void Start () {
		}

	void Update () {

		ScoreText.text = score.ToString ();

		transform.Translate (Vector3.forward * Speed * Time.deltaTime);

		if (Input.GetKey (KeyCode.D)) {
			transform.Rotate (Vector3.right * RotationSpeed * Time.deltaTime);
		}
		if (Input.GetKey (KeyCode.A)) {
			transform.Rotate (Vector3.left * RotationSpeed * Time.deltaTime);
		}
		if (Input.GetKeyDown (KeyCode.Escape)) 
		{
			Application.Quit ();
		}
	
	}

	public void AddTail(){
		score++;
        Debug.Log(tailParts.Count);
        if (tailParts.Count == 0)
        {
            newTailPos = gameObject.transform.position;
        }
        else {
            newTailPos = tailParts[tailParts.Count-1].transform.position;
        }
        tailParts.Add(GameObject.Instantiate (tailPrefab, newTailPos, Quaternion.identity) as GameObject);
	}

	public void SpeedDown(){
		if (Speed > 4) {
			Speed = Speed-2f;
            AddTail();
        }
		else {
			return;}
	}

	public void SpeedUp(){
		
		Speed = Speed+2f;
        AddTail();
    }

    public void RemoveTail() {
        if (tailParts.Count > 0)
        {
            score--;
            Destroy(tailParts[tailParts.Count - 1]);
            tailParts.RemoveAt(tailParts.Count - 1);
        }
    }

}


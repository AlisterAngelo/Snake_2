using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodGeneration : MonoBehaviour {

	public float XSize = 8.5f;
	public float ZSize = 8.5f;
	public GameObject foodPrefab1;
	public Vector3 currPos1;
	public GameObject currFood1;
	public GameObject foodPrefab2;
	public Vector3 currPos2;
	public GameObject currFood2;
	public GameObject foodPrefab3;
	public Vector3 currPos3;
	public GameObject currFood3;
	public GameObject foodPrefab4;
	public Vector3 currPos4;
	public GameObject currFood4;



	void AddNewFood (int numFood){
        switch (numFood)
        {
            case 1:
                currFood1 = GameObject.Instantiate(foodPrefab1, RandomPosition(), Quaternion.identity) as GameObject;
                break;
            case 2:
                currFood2 = GameObject.Instantiate(foodPrefab2, RandomPosition(), Quaternion.identity) as GameObject;
                break;
            case 3:
                currFood3 = GameObject.Instantiate(foodPrefab3, RandomPosition(), Quaternion.identity) as GameObject;
                break;
            case 4:
                currFood4 = GameObject.Instantiate(foodPrefab4, RandomPosition(), Quaternion.identity) as GameObject;
                break;
        }
        
    }
    
    

	Vector3 RandomPosition(){
		Vector3 currPos = new Vector3(Random.Range(XSize*-1,XSize),0.25f,Random.Range(ZSize*-1,ZSize));
        return currPos;
    }
	


	void Update() {
		if (!currFood1) {
			AddNewFood (1);
		} else {
			if (!currFood2) {
				AddNewFood (2);
			} else {				
				if (!currFood3) {
					AddNewFood (3);
				} else {
                    if (!currFood4)
                    {
                        AddNewFood (4);
                    }
		        }
		
        	}
		}
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food4 : MonoBehaviour {

    void OnTriggerEnter(Collider other){
        if (other.CompareTag("SnakeMain")){
            other.GetComponent<SnakeMovement>().RemoveTail();
            Destroy(gameObject);
        }
    }
}

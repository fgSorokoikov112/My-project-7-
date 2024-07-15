using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Death : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other){
        Debug.Log(100);
        if(other.GetComponent<Enemy>()){
            Debug.Log("You are dead!");
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
    public bool Set = false;
    public int num_;
    public int GetNum(){
        return num_;
    }
    public void Center(GameObject cur){
        cur.transform.position = transform.position;
    }
}

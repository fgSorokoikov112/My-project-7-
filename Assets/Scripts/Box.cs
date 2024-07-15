using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
    public bool Set = false;
    public int num_;
    public Building build;
    public int GetNum(){
        return num_;
    }
    static public List<Box> Boxes = new List<Box>();
    void Start(){
        if(Boxes.Count == 0){
            for(int i = 0; i<=25;i++){
                Boxes.Add(null);
            }
        }
        Boxes[num_] = this;

    }
    public void Center(GameObject cur){
        cur.transform.position = transform.position;
    }
}

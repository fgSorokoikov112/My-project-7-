using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Position : MonoBehaviour
{
    static public List<Position> Positions = new List<Position>();
    public int Num;
    void Start(){
        if(Positions.Count == 0){
            for(int i=0;i<8;i++){
                Positions.Add(null);
            }
        }
        Positions[Num] = this;
    }
}

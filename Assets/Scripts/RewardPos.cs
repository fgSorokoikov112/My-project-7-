using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RewardPos : MonoBehaviour
{
    static public List<RewardPos> RPositions = new List<RewardPos>();
    public int Num;
    void Start(){
        if(RPositions.Count == 0){
            for(int i=0;i<2;i++){
                RPositions.Add(null);
            }
        }
        RPositions[Num] = this;
    }
}

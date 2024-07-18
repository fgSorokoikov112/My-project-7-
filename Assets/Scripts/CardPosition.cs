using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardPosition : MonoBehaviour
{
    static public List<CardPosition> CardPositions = new List<CardPosition>();
    public int Num;
    void Start(){
        if(CardPositions.Count == 0){
            for(int i=0;i<8;i++){
                CardPositions.Add(null);
            }
        }
        CardPositions[Num] = this;
    }
}

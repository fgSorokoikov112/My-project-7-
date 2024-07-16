using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardManager : MonoBehaviour
{
    void Start(){
        for(int i=0;i<PlayerStats.CardCount;i++){
            if(ObjectCard.Cards[i])
                ObjectCard.Cards[i].transform.position = Position.Positions[i].transform.position;
        }
    }
}

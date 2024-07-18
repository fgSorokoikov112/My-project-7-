using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackPack : MonoBehaviour
{
    void Start(){
        for(int i = 0; i < PlayerStats.PlayersCards.Count; i++){
            Instantiate(PlayerStats.PlayersCards[i], CardPosition.CardPositions[i].transform);
        }
    }
}

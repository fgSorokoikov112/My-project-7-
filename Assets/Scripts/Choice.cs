
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Choice : MonoBehaviour
{
    public List<ObjectCard> CardsPool = new List<ObjectCard>();
    public List<ObjectCard> UsingCards = new List<ObjectCard>();
    bool alredyExist_ = true;
    bool flag_ = true;
    ObjectCard currentCard_;
    public void LevelWin(){
        for(int j = 0; j < PlayerStats.RewardsCount; j++){
            currentCard_ = CardsPool[Random.Range(0,CardsPool.Count)];
            while(CardsPool.Count != UsingCards.Count && alredyExist_){
                alredyExist_ = false;
                for(int i = 0; i < UsingCards.Count; i++){
                    if(currentCard_ == UsingCards[i]){
                        alredyExist_ = true;
                        i=100;
                    }
                }
            }
            alredyExist_ = true;
            Instantiate(currentCard_, RewardPos.RPositions[j].transform);
        }
    }
}   

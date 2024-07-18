using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardManager : MonoBehaviour
{
    public void NumPressed(){
        if(!CardHandler.flag_){
            for(int i = 1;i < PlayerStats.CardCount+1;i++){
                if(Input.GetKeyDown(Settings.Keys[i])){
                    Debug.Log(i);
                    CardHandler.thisCard_ = ObjectCard.GetCard(i-1);
                    CardHandler.current_ = CardHandler.thisCard_.building.icon;
                    if(PlayerStats.Resource>=CardHandler.thisCard_.Cost && CardHandler.thisCard_.CooledDown){
                        CardHandler.nCurrent_ = Instantiate(CardHandler.current_, Position.Positions[0].transform);
                        CardHandler.flag_ = !CardHandler.flag_;
                    }
                }
            }
        }
    }
    void Update(){
        NumPressed();
    }
    void Start(){
        for(int i=0;i<PlayerStats.CardCount;i++){
            if(ObjectCard.Cards[i])
                ObjectCard.Cards[i].transform.position = Position.Positions[i].transform.position;
        }
    }
}

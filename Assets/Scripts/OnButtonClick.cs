using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnButtonClick : MonoBehaviour
{
    public void ButtonIsPressed(ObjectCard thisCard_){
        Debug.Log(100);
        if(!CardHandler.flag_){
            if(PlayerStats.Resource>=thisCard_.Cost && thisCard_.CooledDown){
                CardHandler.current_ = thisCard_.building.gameObject;
                CardHandler.thisCard_ = thisCard_;
                CardHandler.nCurrent_ = Instantiate(CardHandler.current_, Position.Positions[0].transform);
                CardHandler.flag_ = !CardHandler.flag_;
            }
        }
    }
}

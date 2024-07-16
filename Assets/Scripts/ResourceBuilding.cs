using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ResourceBuilding : Building
{
    bool flag_ = true;
    IEnumerator CreateResource(){
        yield return new WaitForSeconds(AttackSpeed);
        PlayerStats.Resource += Damage;
        flag_ = true;
    }
    void Update(){
        if(flag_){
            flag_ = false;
            StartCoroutine(CreateResource());
        }
    }
}

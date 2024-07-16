using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ResourceBuilding : Building
{
    bool canWork_ = true;
    IEnumerator CreateResource(){
        yield return new WaitForSeconds(AttackSpeed);
        PlayerStats.Resource += Damage;
        canWork_ = true;
    }
    void Update(){
        if(canWork_){
            canWork_ = false;
            StartCoroutine(CreateResource());
        }
    }
}

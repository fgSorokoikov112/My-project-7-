using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class ObjectCard : MonoBehaviour
{
    public Building building;
    public int num_;
    public int Cost;
    public int Cooldown;
    public bool CooledDown = true;
    public static List<ObjectCard> Cards = new List<ObjectCard>();
    void Start(){
        if(Cards.Count == 0){
            for(int i=0;i<PlayerStats.CardCount;i++){
                Cards.Add(null);
            }
        }
        Cards[num_] = this;
    }
    public IEnumerator CardCooldown(){
        yield return new WaitForSeconds(Cooldown);
        CooledDown = true;
    }
    public static ObjectCard GetCard(int num){
        return Cards[num];
    }
}

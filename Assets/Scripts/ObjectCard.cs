using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class ObjectCard : MonoBehaviour
{
    public Building building;
    public int num_;
    public static List<ObjectCard> Cards =new List<ObjectCard>();
    void Start(){
        Cards.Add(this);
    }
    public static ObjectCard GetCard(int num){
        return Cards[num];
    }
}

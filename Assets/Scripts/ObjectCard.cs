using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class ObjectCard : MonoBehaviour
{
    public GameObject Building;
    int num_;
    public static List<ObjectCard> Cards;
    void Start(){
        num_ = Cards.Count;
        Cards.Add(this);
    }
}

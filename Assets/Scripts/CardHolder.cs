using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class CardHolder : MonoBehaviour
{
    [SerializeField] private Transform cardHolderPos_;
    [SerializeField] private GameObject card_;

    [SerializeField] private Card[] cards_;
    [SerializeField] private GameObject[] PlantedCards_;
    private Sprite icon_;
    private int cost_;
    void CreatCard(int i){
        Debug.Log(cardHolderPos_);
        var card = Instantiate(card_, cardHolderPos_);
        PlantedCards_[i] = card;
        //icon_ = cards_[i].icon_;
        cost_ = cards_[i].cost_;
        //card.GetComponentInChildren<SpriteRenderer>().sprite = icon_;
        //card.GetComponentInChildren<TMP_Text>().text = cost_.ToString();
    }
    void Start()
    {
        for(int i = 0;i < cards_.Length;i++){
            CreatCard(i);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardOb : MonoBehaviour
{
    GameObject current_;
    GameObject nCurrent_;
    ObjectCard thisCard_;
    public KeyCode ToggleKey;
    public LayerMask layerMask;
    bool flag_ = false;
    bool Click(){
        if(Input.GetMouseButtonDown(0)){
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2D = new Vector2(mousePos.x,mousePos.y);
            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);
            if(hit.collider == null){
                return false;
            }
            bool isCard = hit.collider.gameObject.TryGetComponent<ObjectCard>(out ObjectCard card);
            if(card!= null){
                Debug.Log("Card is" + isCard);
                thisCard_ = card;
                current_ = card.building.icon;
            }
            return isCard;
        }
        return false;
    }
    bool NumPressed(){
        if(Input.GetKeyDown(KeyCode.Alpha1)){
            thisCard_ = ObjectCard.GetCard(0);
            current_ = thisCard_.building.icon;
            
            return true;
        }
        else if(Input.GetKeyDown(KeyCode.Alpha2)){
            thisCard_ = ObjectCard.GetCard(1);
            current_ = thisCard_.building.icon;
            return true;
        }
        else if(Input.GetKeyDown(KeyCode.Alpha3)){
            return true;
        }
        else if(Input.GetKeyDown(KeyCode.Alpha4)){
            return true;
        }
        return false;
    }
    void Update(){
        if(Click() && !flag_){
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2D = new Vector2(mousePos.x,mousePos.y);
            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);
            nCurrent_ = Instantiate(current_, thisCard_.transform);
            flag_ = !flag_;
        }
        else if(NumPressed() && !flag_){
            nCurrent_ = Instantiate(current_, thisCard_.transform);
            flag_ = !flag_;
        }
        else if (flag_){
            if(Input.GetMouseButtonDown(0)){
                Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                Vector2 mousePos2D = new Vector2(mousePos.x,mousePos.y);
                RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero,layerMask.value);
                if(hit.collider != null){
                    if(hit.collider.gameObject.TryGetComponent<Box>(out Box x)){
                        if(!x.Set){
                            x.Set = true;
                            flag_ = false;
                            x.build = nCurrent_.GetComponent<Building>();
                            x.build.GetComponent<Building>().Stay = true;
                            x.build.GetComponent<Building>().CurrentBox = x;
                            x.Center(nCurrent_);
                        }
                    }
                }
                else{
                    Destroy(nCurrent_);
                }
                if(flag_){
                    Destroy(nCurrent_);
                }
                flag_ = false;
            }
            if(flag_){
                Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                Vector2 mousePos2D = new Vector2(mousePos.x,mousePos.y);
                nCurrent_.transform.position = mousePos2D;
            }
        }
    }
}

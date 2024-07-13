using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardOb : MonoBehaviour
{
    GameObject current_;
    GameObject nCurrent_;
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
                Debug.Log(card.Building.name);
                current_ = card.Building;
            }
            return isCard;
        }
        return false;
    }
    void Update(){
        if(Click() && !flag_){
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2D = new Vector2(mousePos.x,mousePos.y);
            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);
            nCurrent_ = Instantiate(current_, hit.transform);
            flag_ = !flag_;
        }
        else if (flag_){
            if(Input.GetMouseButtonDown(0)){
                Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                Vector2 mousePos2D = new Vector2(mousePos.x,mousePos.y);
                RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);
                if(hit.collider != null){
                    if(hit.collider.gameObject.TryGetComponent<Box>(out Box x)){
                        if(!x.Set){
                            Debug.Log(x.Set);
                            x.Set = true;
                            flag_ = false;
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

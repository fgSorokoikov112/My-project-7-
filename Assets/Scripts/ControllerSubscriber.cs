using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerSubscriber : MonoBehaviour
{
    /*
    public ControllerKey controller;
    public ClickEvent eventController;
    public KeyCode toggleKey;
    bool flag_ = false;
    GameObject current_;
    GameObject nCurrent_;
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
    void Update() {
        if (Click() && !flag_) {
                Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                Vector2 mousePos2D = new Vector2(mousePos.x,mousePos.y);
                RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);
                nCurrent_ = Instantiate(current_, hit.transform);
        }
        else if(Input.GetKeyDown(toggleKey)){
            nCurrent_ = Instantiate(current_, Input.mousePosition);
            flag_ = !flag_;
        }
        if (flag_ && Input.GetMouseButtonDown(0)){
                Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                Vector2 mousePos2D = new Vector2(mousePos.x,mousePos.y);
                eventController.click.AddListener(controller.Move);
                RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);
                if(hit.collider != null){
                    if(hit.collider.gameObject.TryGetComponent<Box>(out Box x)){
                        if(!x.Set){
                            Debug.Log(x.Set);
                            x.Set = true;
                            flag_ = false;
                            x.Center(nCurrent_);
                            eventController.click.RemoveListener(controller.Move);
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
        else if(flag_ && Input.)
    }*/
}

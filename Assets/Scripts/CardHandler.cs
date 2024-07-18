using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardHandler : MonoBehaviour
{
    public static GameObject current_;
    public static GameObject nCurrent_;
    public static ObjectCard thisCard_;
    public KeyCode ToggleKey;
    public LayerMask layerMask;
    public static bool flag_ = false;
    void Update(){
        if (flag_){
            if(Input.GetMouseButtonDown(0)){
                Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                Vector2 mousePos2D = new Vector2(mousePos.x,mousePos.y);
                RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero,layerMask.value);
                if(hit.collider != null){
                    if(hit.collider.gameObject.TryGetComponent<Box>(out Box x)){
                        if(!x.Set){
                            x.Set = true;
                            PlayerStats.Resource -= thisCard_.Cost;
                            flag_ = false;
                            x.build = nCurrent_.GetComponent<Building>();
                            x.build.GetComponent<Building>().Stay = true;
                            x.build.GetComponent<Building>().CurrentBox = x;
                            thisCard_.CooledDown = false;
                            StartCoroutine(thisCard_.CardCooldown());
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

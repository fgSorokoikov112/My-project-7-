using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WastePaper : MonoBehaviour
{
    public GameObject DeleteInstument;
    GameObject current_;
    bool flag_ = false;
    public LayerMask layerMask;
    public bool Click(){
        if(Input.GetMouseButtonDown(0)){
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2D = new Vector2(mousePos.x,mousePos.y);
            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);
            if(hit.collider == null){
                    return false;
            }
            return hit.collider.TryGetComponent<WastePaper>(out WastePaper pap);
        }
        return false;
    }
    void Update(){
        if((Click() || Input.GetKeyDown(Settings.Keys[0])) && !flag_){
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2D = new Vector2(mousePos.x,mousePos.y);
            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);
            current_ = Instantiate(DeleteInstument, transform);
            flag_ = !flag_;
        }
        else if (flag_){
            if(Input.GetMouseButtonDown(0)){
                Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                Vector2 mousePos2D = new Vector2(mousePos.x,mousePos.y);
                RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero,layerMask.value);
                if(hit.collider != null){
                    Debug.Log(hit.collider.gameObject.name);
                    if(hit.collider.gameObject.TryGetComponent<Box>(out Box x)){
                        Debug.Log(10);
                        if(x.Set){
                            Debug.Log(100);
                            x.build.GetComponent<Building>().Delete();
                            x.Set = false;
                            flag_ = !flag_;
                            Destroy(current_);
                        }
                    }
                }
                else{
                    Destroy(current_);
                }
                if(flag_){
                    Destroy(current_);
                }
                flag_ = false;
            }
            if(flag_){
                Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                Vector2 mousePos2D = new Vector2(mousePos.x,mousePos.y);
                current_.transform.position = mousePos2D;
            }
        }
    }
}

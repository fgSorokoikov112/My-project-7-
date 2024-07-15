using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ClickEvent : MonoBehaviour
{
    public Click click;
    void Update(){
        if(Input.GetMouseButtonDown(0)){
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            click.Invoke(mousePos.x,mousePos.y);
        }
    }
}
[System.Serializable]
public class Click : UnityEvent <float, float>{}
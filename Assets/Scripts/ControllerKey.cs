using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerKey : MonoBehaviour
{
    public void Move(GameObject target, float x, float y){
        Vector2 mousePos2D = new Vector2(x,y);
        target.transform.position = mousePos2D;
    }
}

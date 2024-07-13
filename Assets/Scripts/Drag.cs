using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class Drag
{
        public static void onDrag(GameObject ob){
            Vector3 mousePos = Input.mousePosition;
            Vector2 mousePos2D = new Vector2(mousePos.x,mousePos.y);
            ob.transform.position = mousePos2D;
            Debug.Log("succsess");
    }
}

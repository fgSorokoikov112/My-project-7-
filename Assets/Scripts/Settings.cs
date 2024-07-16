using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Settings : MonoBehaviour
{
    public static List<KeyCode> Keys = new List<KeyCode>();
    void DefaultSetting(){
        Keys[0] = KeyCode.Alpha0;
        Keys[1] = KeyCode.Alpha1;
        Keys[2] = KeyCode.Alpha2;
        Keys[3] = KeyCode.Alpha3;
        Keys[4] = KeyCode.Alpha4;
        Keys[5] = KeyCode.Alpha5;
        Keys[6] = KeyCode.Alpha6;
        Keys[7] = KeyCode.Alpha7;
        Keys[8] = KeyCode.Alpha8;
    }
    void Start(){
        for(int i = 0;i < 9;i++){
            Keys.Add(KeyCode.None);
        }
        DefaultSetting();
    }
}

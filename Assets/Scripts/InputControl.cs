using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputControl : MonoBehaviour
{
    public static bool Together = false;
    bool flag_ = false;
    public int Count;
    void OnGUI(){
        if(flag_){
            if(Together){
                Debug.Log(Count);
                Event cur = Event.current;
                if(cur.isKey){
                    Debug.Log(Count);
                    Together = false;
                    flag_ = false;
                    PlayerPrefs.SetInt("Settings", 0);
                    Settings.Keys[Count] = cur.keyCode;
                    PlayerPrefs.SetInt(Count.ToString(), (int)cur.keyCode);
                }
            }
        }
    }
    public void SetFlag(){
        flag_ = !flag_;
    }
    public void SetTogether(){
        Together = true;
    }
    public void SetDefault(){
        PlayerPrefs.SetInt("Settings", 1);
        Settings.DefaultSetting();
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class InputControl : MonoBehaviour
{
    public static bool Together = false;
    bool flag_ = false;
    public int Count;
    public TMP_Text text;
    bool isUse_ = false;
    void OnGUI(){
        if(flag_){
            if(Together){
                Debug.Log(Count);
                Event cur = Event.current;
                if(cur.isKey){
                    for(int i = 0; i < 9; i++){
                        if(PlayerPrefs.HasKey(i.ToString())){
                            if(Settings.Keys[i] == cur.keyCode){
                                isUse_ = true;
                            }
                        }
                    }
                    if(!isUse_){
                        if(PlayerPrefs.HasKey(Count.ToString())){
                            PlayerPrefs.DeleteKey(Count.ToString());
                        }
                        Debug.Log(Count);
                        Together = false;
                        flag_ = false;
                        PlayerPrefs.SetInt("Settings", 0);
                        Settings.Keys[Count] = cur.keyCode;
                        PlayerPrefs.SetInt(Count.ToString(), (int)cur.keyCode);
                    }
                    isUse_ = false;
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
    public void SetKey(){
        //text.SetText(PlayerPrefs.GetInt(Count.ToString()));
    }
    public void SetDefault(){
        PlayerPrefs.SetInt("Settings", 1);
        Settings.DefaultSetting();
    }
}

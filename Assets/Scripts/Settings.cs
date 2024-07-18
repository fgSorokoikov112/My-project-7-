using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Settings : MonoBehaviour
{
    public static List<KeyCode> Keys = new List<KeyCode>();
    public static List<KeyCode> CurrentKeys = new List<KeyCode>();
    static public void DefaultSetting(){
        for(int i = 0; i < 9; i++){
            Keys[i] = (KeyCode)(i+48);
        }
        PlayerPrefs.DeleteAll();
    }
    void Start(){
        for(int i = 0;i < 9;i++){
            Keys.Add(KeyCode.None);
        }
        if(PlayerPrefs.GetInt("Settings") == 1){
            DefaultSetting();
        }
        else{
            for(int i = 0; i < 9; i++){
                if(PlayerPrefs.HasKey(i.ToString())){
                    Keys[i] = (KeyCode)PlayerPrefs.GetInt(i.ToString());
                }
                else{
                    Keys[i] = (KeyCode)(i+48);
                }
            }
        }
        for(int i=0; i < 9; i++){
            Debug.Log(Keys[i]);
        }
        DontDestroyOnLoad(gameObject);
    }
}

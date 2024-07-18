using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ChangeScene : MonoBehaviour
{
    public void PlayGame(string name){
        SceneManager.LoadScene(name);
    }
    public void ExitGame(){
        Debug.Log("Exit");
    }
}

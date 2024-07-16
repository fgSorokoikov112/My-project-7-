using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ResourceBar : MonoBehaviour
{
    public TMP_Text text;
    void Update(){
        text.SetText((PlayerStats.Resource).ToString());
    }
}

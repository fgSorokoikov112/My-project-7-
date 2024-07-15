using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public static int spawnerPoints_ = 1;
    public int Num;
    static public List<Spawner> Spawners = new List<Spawner>();
    void Start(){
        Num = Spawners.Count;
        Spawners.Add(this);
    }
}

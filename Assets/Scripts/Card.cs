using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
[CreateAssetMenu]
public class Card : ScriptableObject
{
    public Sprite icon_;
    public int cost_;
    public GameObject prefab_;
}

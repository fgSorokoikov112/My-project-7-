using System;
using System.Buffers.Text;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class OnHit : MonoBehaviour
{
    public OnHitEnemy hit;
}
[Serializable]
public class OnHitEnemy: UnityEvent <Enemy>{}

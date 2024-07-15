using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Building : MonoBehaviour
{
    public int Health;
    public int Damage;
    public float AttackSpeed;
    public Box CurrentBox;
    public Bullet TBullet;
    public GameObject icon;
    public bool Stay = false;
    public void Delete(){
        Destroy(gameObject);
    }
}

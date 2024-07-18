using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public abstract class Enemy : MonoBehaviour
{
    public GameObject sprite;
    public float speed;
    public float MaxSpeed = 10;
    public int Health;
    public int Cost;
    public bool flag = true;
    public Rigidbody2D body;
    public void Move(){
        if(flag){
            if(body.velocity.magnitude < MaxSpeed){
                body.AddForce(speed * new Vector2(-1,0), ForceMode2D.Force);
            }
        }
        else{
            body.velocity = Vector2.zero;
        }
    }
    void Start(){
        MaxSpeed+=Random.Range(0.0f, 0.2f);
        speed += Random.Range(0.0f, 0.1f);
    }
    public void Death(){
        Destroy(gameObject);
    }
    public abstract void Attack(Box box);
    public abstract void Special();
}

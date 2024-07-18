using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Bullet : MonoBehaviour
{
    public float maxBulletSpeed = 10.0f;
    public float BulletSpeed = 5.0f;
    public OnHit HitEvent;
    public int Damage;
    public GameObject Bull;
    public void DealDamage(Enemy enemy){
        enemy.Health -= Damage;
        SpawnerPoint.WaveDamage += Damage;
        if(enemy.Health<0)
            SpawnerPoint.WaveDamage += enemy.Health;
        if(enemy.Health<=0){
            enemy.Death();
        }
    }
    public virtual void OnTriggerEnter2D(Collider2D other){}
    public void DestroyOnHit(Enemy enemy){
        Destroy(gameObject);
    }
    public virtual void Special(){}
    public abstract void Move();
}

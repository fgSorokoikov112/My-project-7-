using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PenetrationBullet : Bullet
{
    public int count;
    public override void Move(){
        if(gameObject.GetComponent<Rigidbody2D>().velocity.magnitude < maxBulletSpeed)
                gameObject.GetComponent<Rigidbody2D>().AddForce(BulletSpeed*Time.deltaTime * new Vector2(1,0), ForceMode2D.Force);
    }
    public override void OnTriggerEnter2D(Collider2D other){
        if(count==0){
            if(other.gameObject.TryGetComponent<Enemy>(out Enemy enemy)){
                HitEvent.hit.AddListener(DealDamage);
                HitEvent.hit.AddListener(DestroyOnHit);
                HitEvent.hit.Invoke(enemy);
            }
        }
        else
            count--;
    }
}

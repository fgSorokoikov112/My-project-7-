using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleBullet : Bullet
{
    public override void Special(){

    }
    void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.TryGetComponent<Enemy>(out Enemy enemy)){
            HitEvent.hit.Invoke(enemy);
        }
    }
    public void Start(){
        HitEvent.hit.AddListener(DealDamage);
        HitEvent.hit.AddListener(DestroyOnHit);
    }
    public override void Move(){
        if(gameObject.GetComponent<Rigidbody2D>().velocity.magnitude < maxBulletSpeed)
                gameObject.GetComponent<Rigidbody2D>().AddForce(BulletSpeed*Time.deltaTime * new Vector2(1,0), ForceMode2D.Force);
    }
}

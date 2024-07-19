using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SimpleEnemy : Enemy
{
    private IEnumerator coroutine;

    public override void Attack(Box box){
        flag = false;
        coroutine = AttackWithDelay(box,2);
        StartCoroutine(coroutine);
    }
    IEnumerator AttackWithDelay(Box box,float delay){
        while(box.build.Health > 0){
            yield return new WaitForSeconds(delay);
            box.build.Health--;
        }
        box.GetComponent<Box>().Set = false;
        flag = true;
        box.build.Delete();
    }
    public override void Special(){

    }
    public void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.TryGetComponent<Box>(out Box box)){
            if(box.Set){
                Attack(box);
            }
        }
    }
    public override IEnumerator Unkillable(float delay){
        yield return new WaitForSeconds(delay);
        CanTakeDamage = true;
    }
    void Update(){
        Move();
    }
}

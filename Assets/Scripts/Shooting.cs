using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public bool CanShoot = true;
    Bullet currentBullet_;
    public LayerMask layerMask;
    Building building;
    public void Shoot(){
        RaycastHit2D hit = Physics2D.Raycast(building.CurrentBox.transform.position,new Vector2(1,0), 100, layerMask.value);
        if(hit.collider != null){
            if(hit.collider.gameObject.TryGetComponent<Enemy>(out Enemy enemy) && enemy.Health>0 && CanShoot){
                CanShoot= !CanShoot;
                StartCoroutine(Attack());
            }
        }
        if(currentBullet_ != null)
            currentBullet_.Move();

    }
    public IEnumerator Attack(){
        Spawn();
        Debug.Log(building.AttackSpeed);
        yield return new WaitForSeconds(building.AttackSpeed);
        CanShoot = !CanShoot;
    }
    void Spawn(){
        currentBullet_ = Instantiate(building.TBullet.Bull,transform.position,building.TBullet.Bull.transform.rotation).GetComponent<Bullet>();
    }
    void Start(){
        building = GetComponent<Building>();
    }
     void Update(){
        if(building.Stay){
            if(enabled)
                Shoot();
        }
    }
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Board : MonoBehaviour
{
    List<Box> board_ = new List<Box>();
    public Enemy enemy;
    public int delay;
    bool flag_ = true;
    void SpawnEnemy(){
        int random = Random.Range(0,5);
        Instantiate(enemy.sprite, Spawner.Spawners[random].transform);
    }
    void Update(){
        if(Spawner.spawnerPoints_ > 0 && flag_){
            flag_ = false;
            StartCoroutine(SpawnEnemyWithDelay());
            Spawner.spawnerPoints_--;
        }
    }
    IEnumerator SpawnEnemyWithDelay(){
        yield return new WaitForSeconds(delay);
        SpawnEnemy();
        flag_ = true;
    }
}

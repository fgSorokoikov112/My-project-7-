
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Board : MonoBehaviour
{
    List<Box> board_ = new List<Box>();
    public Enemy enemy;
    void SpawnEnemy(GameObject enemy){
        int random = Random.Range(1,3);
        Instantiate(enemy, Spawner.Spawners[random].transform);
    }
    void Update(){
        if(Spawner.spawnerPoints_ > 0){
            SpawnEnemy(enemy.sprite);
            Spawner.spawnerPoints_--;
        }
    }
}

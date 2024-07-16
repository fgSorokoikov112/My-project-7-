
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Board : MonoBehaviour
{
    List<Box> board_ = new List<Box>();
    public List<Enemy> EnemyPool = new List<Enemy>();
    Enemy enemy;
    public int delay;
    int startSpawnPoints_;
    public int WaveCount;
    bool flag_ = true;
    void SpawnEnemy(){
        int random = Random.Range(0,5);
        Spawner.spawnerPoints_-=enemy.Cost;
        SpawnerPoint.WaveHealth += enemy.Health;
        Instantiate(enemy.sprite, Spawner.Spawners[random].transform);
    }
    void Update(){
        if(flag_ && WaveCount != 0){
            if(SpawnerPoint.WaveDamage == (SpawnerPoint.WaveHealth)/2){
            while(Spawner.spawnerPoints_ != 0){
                enemy = EnemyPool[Random.Range(0,EnemyPool.Count)];
                for(;Spawner.spawnerPoints_ - enemy.Cost >=0;){
                    flag_ = false;
                    SpawnerPoint.WaveDamage = 0;
                    SpawnerPoint.WaveHealth = 0;
                    StartCoroutine(SpawnEnemyWithDelay());
                }
            }
                WaveCount--;
                Spawner.spawnerPoints_ = startSpawnPoints_ * 2;
                startSpawnPoints_ *= 2;
            }
        }
    }
    void Start(){
        startSpawnPoints_ = Spawner.spawnerPoints_;
    }
    IEnumerator SpawnEnemyWithDelay(){
        yield return new WaitForSeconds(delay);
        SpawnEnemy();
        flag_ = true;
    }
}

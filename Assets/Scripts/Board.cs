
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Board : MonoBehaviour
{
    List<Box> board_ = new List<Box>();
    public ProgressBar progressBar;
    public List<Enemy> EnemyPool = new List<Enemy>();
    Enemy enemy;
    public Choice TChoice;
    public float delay;
    int startSpawnPoints_;
    public int WaveCount;
    public int Difficulty;
    int WaveHealth;
    int StartWaveCount;
    bool flag_ = true;
    bool won_ = false;
    void SpawnEnemy(Enemy curEnemy){
        int random = Random.Range(0,5);
        WaveHealth += curEnemy.Health;
        Instantiate(curEnemy.sprite, Spawner.Spawners[random].transform);
    }
    IEnumerator Progress(){
        yield return new WaitForSeconds(0.1f);
        if(progressBar.BarValue - (StartWaveCount - WaveCount - 1)*(100/StartWaveCount)<100/StartWaveCount){
            Debug.Log("akdsksadksd");
            progressBar.BarValue =progressBar.BarValue + 100/StartWaveCount/10;
            StartCoroutine(Progress());
        }
    }
    void Win(){
        if(progressBar.BarValue<100)
            progressBar.BarValue = 100;
        Debug.Log("You won!");
        //TChoice.LevelWin();
        won_ = true;
    }
    void Update(){
        if(flag_ && WaveCount > 0){
            if(SpawnerPoint.WaveDamage >= (WaveHealth)/2){
                while(Spawner.spawnerPoints_ > 0){
                    enemy = EnemyPool[Random.Range(0,EnemyPool.Count)];
                    if(Spawner.spawnerPoints_ - enemy.Cost >=0){
                        Spawner.spawnerPoints_-=enemy.Cost;
                        flag_ = false;
                        StartCoroutine(SpawnEnemyWithDelay(enemy));
                    }
                }
                WaveCount--;
                Spawner.spawnerPoints_ = startSpawnPoints_;
                startSpawnPoints_ += Difficulty;
                Difficulty++;
            }
        }
        if(SpawnerPoint.WaveDamage == WaveHealth && WaveCount == 0 && !won_){
            Win();
        }
    }
    void Start(){
        StartWaveCount = WaveCount;
        startSpawnPoints_ = Spawner.spawnerPoints_;
    }
    IEnumerator SpawnEnemyWithDelay(Enemy curEnemy){
        StartCoroutine(Progress());
        yield return new WaitForSeconds(Random.Range(2.0f, delay));
        SpawnEnemy(curEnemy);
        flag_ = true;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemy;
    public GameObject powerUp;
    private float spawnPosRange = 9f;
    private int enemiesPerWave = 1;
    private int enemiesLeft;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(powerUp, RandomSpawnPos(), powerUp.transform.rotation);
        SpawnEnemyWave(enemiesPerWave);
    }

    // Update is called once per frame
    void Update()
    {
        enemiesLeft = FindObjectsOfType<Enemy>().Length;
        if (enemiesLeft <= 0)
        {
            enemiesPerWave++;
            SpawnEnemyWave(enemiesPerWave);
            Instantiate(powerUp, RandomSpawnPos(), powerUp.transform.rotation);
        }
    }
    private Vector3 RandomSpawnPos()
    {
        float Xpos = Random.Range(9, -9);
        float Ypos = 1f;
        float Zpos = Random.Range(9, -9);
        return new Vector3(Xpos, Ypos, Zpos);
    }

    private void SpawnEnemy()
    {
        Instantiate(enemy, RandomSpawnPos(), transform.rotation);
    }
    private void SpawnEnemyWave(int totalEnemies)
    {
        for(int i = 0; i < totalEnemies; i++)
        {
            SpawnEnemy();
        }
    }
    
}

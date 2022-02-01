using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemy;
    private float startSpawn = 2f;
    private float repeatRate = 4f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnEnemy", startSpawn, repeatRate);
    }

    // Update is called once per frame
    void Update()
    {
        
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
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Rigidbody enemyRigidbody;

    private GameObject player;

    [SerializeField] private float speed = 10f;

    void Start()
    {
        enemyRigidbody = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
    }

    void Update()
    {
        
    }

    private void SpawnBullet()
    {
        //instantiate()
    }
}

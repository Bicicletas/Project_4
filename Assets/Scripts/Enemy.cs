using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Rigidbody enemyRigidbody;

    private GameObject player;

    [SerializeField] private float speed = 10f;

    private float minHight = -5f;

    void Start()
    {
        enemyRigidbody = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
    }

    void Update()
    {
<<<<<<< HEAD
        Vector3 direction = (player.transform.position - transform.position).normalized;
        enemyRigidbody.AddForce(direction * speed);
        if (transform.position.y < minHight)
        {
            Destroy(gameObject);
        }
=======
        
    }

    private void SpawnBullet()
    {
        //instantiate()
>>>>>>> baec9e8b4e4f3100614b23cd0beaf91cc47937bf
    }
}

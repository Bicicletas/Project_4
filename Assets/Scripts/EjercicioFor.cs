using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjercicioFor : MonoBehaviour
{
    public int initial = 20;
    public GameObject[] enemyPrefabs;
    public Vector3[] positions;

    void Start()
    {
        /*
        for (int i = initial; i >= 0; i--)
        {
            Debug.Log($"{i}");
        }
        
        for (int i = 0; i < enemyPrefabs.Length; i++)
        {
            Instantiate(enemyPrefabs[i], positions[i], enemyPrefabs[i].transform.rotation);
        }*/
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine(fadeCorroutine());
        }
    }
    public IEnumerator fadeCorroutine()
    {
        float alphaValue = 0;
        MeshRenderer cubeMeshRenderer = GetComponent<MeshRenderer>();
        Color color = cubeMeshRenderer.material.color;
        while (alphaValue <= 1)
        {
            color.a = alphaValue;
            print(color);
            cubeMeshRenderer.material.color = color;
            alphaValue += 0.1f;
            yield return new WaitForSeconds(1);
        }
    }
}

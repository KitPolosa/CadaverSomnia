using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFor3 : MonoBehaviour
{
    public GameObject EnemySpawn1;
    public GameObject EnemySpawn2;
    public GameObject EnemySpawn3;
    public float randomX;
    // Start is called before the first frame update
    void Start()
    {
        randomX = Random.Range(4, 7);
        if (randomX == 4)
        {
            EnemySpawn1.SetActive(true);
        }
        else if (randomX == 5)
        {
            EnemySpawn2.SetActive(true);
        }
        else if (randomX == 6 || randomX == 7)
        {
            EnemySpawn3.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
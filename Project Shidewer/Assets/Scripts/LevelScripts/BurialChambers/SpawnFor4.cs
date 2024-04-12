using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFor4 : MonoBehaviour
{
    public GameObject EnemySpawn1;
    public GameObject EnemySpawn2;
    public GameObject EnemySpawn3;
    public GameObject EnemySpawn4;
    public float randomX;
    // Start is called before the first frame update
    void Start()
    {
        randomX = Random.Range(4, 9);
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
        else if (randomX == 8 || randomX == 9)
        {
            EnemySpawn4.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
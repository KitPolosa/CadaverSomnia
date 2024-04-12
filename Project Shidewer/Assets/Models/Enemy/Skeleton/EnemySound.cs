using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySound : MonoBehaviour
{
    public AudioSource NoiseSource1;
    public AudioSource NoiseSource2;
    public AudioSource NoiseSource3;
    public AudioSource NoiseSource4;
    public AudioSource NoiseSource5;

    private float randomX;
    private float spawnDelay;
    float nextSpawn = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextSpawn)
        {
            spawnDelay = Random.Range(3, 10);
            nextSpawn = Time.time + spawnDelay;
            randomX = Random.Range(1, 4);
            if (randomX == 1)
            {
                NoiseSource1.Play();
            }
            else if (randomX == 2)
            {
                NoiseSource5.Play();
            }
            else if (randomX == 3)
            {
                NoiseSource3.Play();
            }
            else if (randomX == 4)
            {
                NoiseSource4.Play();
            }
        }
    }
}
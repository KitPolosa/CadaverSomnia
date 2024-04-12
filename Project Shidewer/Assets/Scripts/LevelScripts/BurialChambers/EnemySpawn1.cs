using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn1 : MonoBehaviour
{
    public GameObject Enemy1;
    public GameObject Enemy2;
    public GameObject Enemy3;

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Start()
    {
        yield return new WaitForSeconds(4.5f);
        Enemy1.SetActive(true);
        Enemy2.SetActive(true);
        Enemy3.SetActive(true);
    }
}
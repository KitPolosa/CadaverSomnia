using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravekeeperSpawn : MonoBehaviour
{
    public GameObject ParticleSystem;
    public GameObject Gravekeeper;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(Spawn());
    }

    public IEnumerator Spawn()
    {
        yield return new WaitForSeconds(4f);
        Gravekeeper.SetActive(true);
        yield return new WaitForSeconds(2f);
        ParticleSystem.SetActive(true);
        yield return new WaitForSeconds(5f);
        ParticleSystem.SetActive(false);
    }
}
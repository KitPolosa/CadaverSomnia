using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowSourceEnemy : MonoBehaviour
{
    public AudioSource bowSound;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            bowSound.Play();
            StartCoroutine(ShotTimer());
        }
    }

    public IEnumerator ShotTimer()
    {
        yield return new WaitForSeconds(5f);
        Destroy(gameObject);
    }
}
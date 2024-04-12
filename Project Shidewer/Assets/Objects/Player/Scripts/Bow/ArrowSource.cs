using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowSource : MonoBehaviour
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
        if (other.tag == "Enemy")
        {
            bowSound.Play();
            StartCoroutine(ShotTimer());
        }
        if (other.tag == "EnemyGD")
        {
            bowSound.Play();
            StartCoroutine(ShotTimer());
        }
        if (other.tag == "EnemySU")
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
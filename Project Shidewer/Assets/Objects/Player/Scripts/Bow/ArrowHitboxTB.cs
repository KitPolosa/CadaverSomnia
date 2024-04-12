using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowHitboxTB : MonoBehaviour
{
    public int damage;
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
            other.GetComponent<HealthEnemy>().Damage(damage);
            bowSound.Play();
        }
        if (other.tag == "EnemyGD")
        {
            other.GetComponent<GDHealth>().Damage(damage);
            bowSound.Play();
        }
        if (other.tag == "EnemySU")
        {
            other.GetComponent<GDHealth2>().Damage(damage);
            bowSound.Play();
        }
    }
}
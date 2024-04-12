using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitBoxDamageCA : MonoBehaviour
{
    public int damage;
    public AudioSource damSound;
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
            damSound.Play();
        }
        if (other.tag == "EnemyGD")
        {
            other.GetComponent<GDHealth>().Damage(damage);
            damSound.Play();
        }
        if (other.tag == "EnemySU")
        {
            other.GetComponent<GDHealth2>().Damage(damage);
            damSound.Play();
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowHitboxDamage : MonoBehaviour
{
    public int damage;
    public GameObject arr;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator ShotTimer()
    {
        yield return new WaitForSeconds(0.05f);
        Destroy(gameObject);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
        {
            other.GetComponent<HealthEnemy>().Damage(damage);
            arr.GetComponent<Renderer>().enabled = false;
            Destroy(gameObject);
        }
        if (other.tag == "EnemyGD")
        {
            other.GetComponent<GDHealth>().Damage(damage);
            arr.GetComponent<Renderer>().enabled = false;
            Destroy(gameObject);
        }
        if (other.tag == "EnemySU")
        {
            other.GetComponent<GDHealth2>().Damage(damage);
            arr.GetComponent<Renderer>().enabled = false;
            Destroy(gameObject);
        }
    }
}
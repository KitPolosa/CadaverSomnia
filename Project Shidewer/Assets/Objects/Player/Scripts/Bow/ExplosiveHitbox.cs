using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosiveHitbox : MonoBehaviour
{
    public GameObject arrowea;
    //public GameObject Exp;
    public int damage;
    // Start is called before the first frame update
    void Start()
    {
        //Exp = Resources.Load("Explosions") as GameObject;
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
            Destroy(arrowea, 1);
            //Destroy(Exp, 1);
        }
        if (other.tag == "EnemyGD")
        {
            other.GetComponent<GDHealth>().Damage(damage);
            Destroy(arrowea, 1);
            //Destroy(Exp, 1);
        }
        if (other.tag == "EnemySU")
        {
            other.GetComponent<GDHealth2>().Damage(damage);
            Destroy(arrowea, 1);
            //Destroy(Exp, 1);
        }
    }
}
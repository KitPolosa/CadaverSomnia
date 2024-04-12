using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowHitboxEA : MonoBehaviour
{
    public GameObject Expl;
    public GameObject Expls;
    Rigidbody rigidBody;
    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
        {
            Expl.SetActive(true);
            Expls.SetActive(true);
            rigidBody.constraints = RigidbodyConstraints.FreezePosition;
        }
        if (other.tag == "EnemyGD")
        {
            Expl.SetActive(true);
            Expls.SetActive(true);
            rigidBody.constraints = RigidbodyConstraints.FreezePosition;
        }
        if (other.tag == "EnemySU")
        {
            Expl.SetActive(true);
            Expls.SetActive(true);
            rigidBody.constraints = RigidbodyConstraints.FreezePosition;
        }
    }
}
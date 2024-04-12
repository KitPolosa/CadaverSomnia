using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FarAttackSU : MonoBehaviour
{
    public GameObject su;
    public GDScript EnemyS;
    // Start is called before the first frame update
    void Start()
    {
        EnemyS = su.GetComponent<GDScript>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerStay(Collider col)
    {
        if (col.tag == "Player")
        {
            EnemyS.atflag = true;
        }
    }
    void OnTriggerExit(Collider col)
    {
        if (col.tag == "Player")
        {
            EnemyS.atflag = false;
        }
    }
}
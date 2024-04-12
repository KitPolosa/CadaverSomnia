using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FarAttackGD : MonoBehaviour
{
    public GameObject gd;
    public GDScript2 EnemyG;
    // Start is called before the first frame update
    void Start()
    {
        EnemyG = gd.GetComponent<GDScript2>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerStay(Collider col)
    {
        if (col.tag == "Player")
        {
            EnemyG.atflag = true;
        }
    }
    void OnTriggerExit(Collider col)
    {
        if (col.tag == "Player")
        {
            EnemyG.atflag = false;
        }
    }
}
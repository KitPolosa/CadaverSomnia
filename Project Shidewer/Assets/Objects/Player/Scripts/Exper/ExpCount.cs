using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExpCount : MonoBehaviour
{
    public Experience Exper;
    public int expUp;
    public bool IsDeath;
    public int HealthAI;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (HealthAI <= 0)
        {
            IsDeath = true;
        }
        if (IsDeath == true)
        {
            Exper.Exp += expUp;
        }
    }
}
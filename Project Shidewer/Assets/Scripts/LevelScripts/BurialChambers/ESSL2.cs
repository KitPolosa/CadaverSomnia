﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ESSL2 : MonoBehaviour
{
    public GameObject Enemy1;
    public GameObject Enemy2;
    public GameObject Enemy3;
    public GameObject Enemy4;
    public GameObject Enemy5;
    public GameObject Enemy6;
    // Start is called before the first frame update
    IEnumerator Start()
    {
        yield return new WaitForSeconds(5f);
        Enemy1.SetActive(true);
        yield return new WaitForSeconds(5f);
        Enemy2.SetActive(true);
        Enemy3.SetActive(true);
        yield return new WaitForSeconds(5f);
        Enemy4.SetActive(true);
        Enemy5.SetActive(true);
        Enemy6.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
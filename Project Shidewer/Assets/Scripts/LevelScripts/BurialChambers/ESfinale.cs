using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ESfinale : MonoBehaviour
{
    public GameObject Enemy1;
    public GameObject Enemy2;
    public GameObject Enemy3;
    public GameObject Enemy4;
    public GameObject Enemy5;
    public GameObject Enemy6;
    public GameObject Enemy7;
    public GameObject Enemy8;
    public GameObject Enemy9;
    public GameObject Enemy10;
    public GameObject Enemy11;
    public GameObject Enemy12;
    // Start is called before the first frame update
    IEnumerator Start()
    {
        yield return new WaitForSeconds(9f);
        Enemy1.SetActive(true);
        Enemy2.SetActive(true);
        yield return new WaitForSeconds(7f);
        Enemy3.SetActive(true);
        Enemy4.SetActive(true);
        yield return new WaitForSeconds(7f);
        Enemy5.SetActive(true);
        Enemy6.SetActive(true);
        yield return new WaitForSeconds(8f);
        Enemy8.SetActive(true);
        Enemy9.SetActive(true);
        yield return new WaitForSeconds(9f);
        Enemy9.SetActive(true);
        Enemy10.SetActive(true);
        yield return new WaitForSeconds(8f);
        Enemy11.SetActive(true);
        Enemy12.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
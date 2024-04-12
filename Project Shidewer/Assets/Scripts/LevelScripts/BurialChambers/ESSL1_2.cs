using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ESSL1_2 : MonoBehaviour
{
    public GameObject Enemy1;
    public GameObject Enemy2;
    public GameObject Enemy3;
    public GameObject Enemy4;
    public GameObject Enemy5;
    public GameObject Enemy6;
    public GameObject Enemy7;
    public GameObject Enemy8;
    // Start is called before the first frame update
    IEnumerator Start()
    {
        yield return new WaitForSeconds(4.5f);
        Enemy1.SetActive(true);
        Enemy2.SetActive(true);
        yield return new WaitForSeconds(6f);
        Enemy3.SetActive(true);
        Enemy4.SetActive(true);
        yield return new WaitForSeconds(5f);
        Enemy5.SetActive(true);
        Enemy6.SetActive(true);
        yield return new WaitForSeconds(5f);
        Enemy7.SetActive(true);
        Enemy8.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
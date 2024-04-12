using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ESSL1 : MonoBehaviour
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
        yield return new WaitForSeconds(4f);
        Enemy1.SetActive(true);
        yield return new WaitForSeconds(5f);
        Enemy2.SetActive(true);
        yield return new WaitForSeconds(4f);
        Enemy3.SetActive(true);
        yield return new WaitForSeconds(4f);
        Enemy4.SetActive(true);
        yield return new WaitForSeconds(4f);
        Enemy5.SetActive(true);
        yield return new WaitForSeconds(4f);
        Enemy6.SetActive(true);
        yield return new WaitForSeconds(4f);
        Enemy7.SetActive(true);
        yield return new WaitForSeconds(4f);
        Enemy8.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
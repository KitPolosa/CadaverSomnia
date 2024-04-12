using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EST2 : MonoBehaviour
{
    public GameObject Enemy1;
    public GameObject Enemy2;
    public GameObject Enemy3;
    public GameObject Enemy4;
    public GameObject Enemy5;
    public GameObject Enemy6;
    public GameObject Enemy7;
    // Start is called before the first frame update
    IEnumerator Start()
    {
        yield return new WaitForSeconds(3f);
        Enemy1.SetActive(true);
        Enemy2.SetActive(true);
        Enemy3.SetActive(true);
        yield return new WaitForSeconds(6f);
        Enemy4.SetActive(true);
        Enemy5.SetActive(true);
        Enemy6.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
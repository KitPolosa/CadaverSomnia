using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ESBC9 : MonoBehaviour
{
    public GameObject Enemy1;
    public GameObject Enemy2;
    public GameObject Enemy3;
    public GameObject Enemy4;
    // Start is called before the first frame update
    IEnumerator Start()
    {
        yield return new WaitForSeconds(5f);
        Enemy1.SetActive(true);
        Enemy2.SetActive(true);
        yield return new WaitForSeconds(9f);
        Enemy3.SetActive(true);
        Enemy4.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
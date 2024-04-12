using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleScript : MonoBehaviour
{
    public GameObject titles;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void openTitles()
    {
        titles.SetActive(true);
    }

    public void closeTitles()
    {
        titles.SetActive(false);
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextScript : MonoBehaviour
{
    public GameObject nextPanel;
    public GameObject currentPanel;
    public GameObject backPanel;
    public GameObject canvasgame;
    public GameObject exc;
    public GameObject joystick;
    public GameObject dodge;
    public GameObject skills1;
    public GameObject skills2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Next()
    {
        currentPanel.SetActive(false);
        nextPanel.SetActive(true);
    }

    public void Back()
    {
        currentPanel.SetActive(false);
        backPanel.SetActive(true);
    }

    public void CanvasClose()
    {
        currentPanel.SetActive(false);
        canvasgame.SetActive(false);
        exc.SetActive(true);
        joystick.SetActive(true);
        dodge.SetActive(true);
        skills1.SetActive(true);
        skills2.SetActive(true);
    }
}
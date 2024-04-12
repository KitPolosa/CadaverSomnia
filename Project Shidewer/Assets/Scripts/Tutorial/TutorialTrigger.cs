using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialTrigger : MonoBehaviour
{
    public GameObject canvass;
    public GameObject panel1;
    public GameObject joystick;
    public GameObject dodge;
    public Joystick StopMove;
    public GameObject tutorialBut;
    public GameObject exc;
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

    public void TutorialPanelOpen()
    {
        StopMove.StopMove();
        canvass.SetActive(true);
        panel1.SetActive(true);
        joystick.SetActive(false);
        dodge.SetActive(false);
        tutorialBut.SetActive(false);
        skills1.SetActive(false);
        skills2.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "TutorialTrigger")
        {
            tutorialBut.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "TutorialTrigger")
        {
            tutorialBut.SetActive(false);
        }
    }
}
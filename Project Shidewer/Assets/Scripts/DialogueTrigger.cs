using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueTrigger : MonoBehaviour
{
    public GameObject panel;
    public GameObject dialogueTrigger;
    public GameObject joystick;
    public GameObject dodge;
    public MobileController StopMove;

    void Start()
    {

    }

    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            StopMove.StopMove();
            panel.SetActive(true);
            dialogueTrigger.SetActive(false);
            joystick.SetActive(false);
            dodge.SetActive(false);
        }
    }
}
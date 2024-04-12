using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharTrigger : MonoBehaviour
{
    public GameObject panel;
    public GameObject charTrigger;
    public GameObject joystick;
    public GameObject dodge;
    public Joystick StopMove;
    public GameObject CharBuyBut;
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

    public void CharPanelOpen()
    {
        StopMove.StopMove();
        panel.GetComponent<Canvas>().enabled = true;
        joystick.SetActive(false);
        dodge.SetActive(false);
        CharBuyBut.SetActive(false);
        skills1.SetActive(false);
        skills2.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "ChTrigger")
        {
            CharBuyBut.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "ChTrigger")
        {
            CharBuyBut.SetActive(false);
        }
    }

    public void ClosePanel()
    {
        panel.GetComponent<Canvas>().enabled = false;
        joystick.SetActive(true);
        dodge.SetActive(true);
        skills1.SetActive(true);
        skills2.SetActive(true);
    }
}
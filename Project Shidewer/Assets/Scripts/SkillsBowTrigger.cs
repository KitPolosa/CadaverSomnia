using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillsBowTrigger : MonoBehaviour
{
    public GameObject panel;
    public GameObject skillsBowTrigger;
    public GameObject joystick;
    public GameObject dodge;
    public Joystick StopMove;
    public GameObject SkillsBowBuyBut;
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

    public void SkillsPanelOpen()
    {
        StopMove.StopMove();
        panel.GetComponent<Canvas>().enabled = true;
        joystick.SetActive(false);
        dodge.SetActive(false);
        SkillsBowBuyBut.SetActive(false);
        skills1.SetActive(false);
        skills2.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "SkillsBowTrigger")
        {
            SkillsBowBuyBut.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "SkillsBowTrigger")
        {
            SkillsBowBuyBut.SetActive(false);
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
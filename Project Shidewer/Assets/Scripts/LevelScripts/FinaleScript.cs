using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinaleScript : MonoBehaviour
{
    public CharacterController characterController;
    public Joystick StopMove;
    public GameObject joystick;
    public GameObject screenFaderout;
    public GameObject screenFaderin;
    public GameObject congMessage;
    public GameObject menuButton;
    public GameObject LC;
    public GameObject EC;
    public GameObject TC;
    public GameObject fpanel;
    public Timer tlag;
    public LevelCount LeC;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            StartCoroutine(Teleport());
        }
    }

    IEnumerator Teleport()
    {
        StopMove.StopMove();
        characterController.enabled = false;
        joystick.SetActive(false);
        screenFaderout.SetActive(true);
        LeC.Exp += 1;
        yield return new WaitForSeconds(4f);
        screenFaderin.SetActive(true);
        yield return new WaitForSeconds(5f);
        Time.timeScale = 0f;
        congMessage.SetActive(true);
        menuButton.SetActive(true);
        fpanel.SetActive(true);
        LC.SetActive(true);
        EC.SetActive(true);
        TC.SetActive(true);
    }
}
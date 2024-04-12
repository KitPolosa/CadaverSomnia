using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine.UI;
using UnityEngine;
using System.Globalization;
using System;

public class FarewellHallScript : MonoBehaviour
{
    public GameObject Player;
    public Vector3 _targetPoint;
    public CharacterController characterController;
    public Joystick StopMove;
    public ScreenFaderOut screenFader;
    public GameObject SF;
    public GameObject thisArena;
    public GameObject otherArena;
    public GameObject joystick;
    public LevelCount LC;

    void Start()
    {
        screenFader = GetComponent<ScreenFaderOut>();
    }

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
        ScreenFaderOut otherScript = SF.GetComponent<ScreenFaderOut>();
        SF.SetActive(true);
        otherScript.ScrrenFade();
        StopMove.StopMove();
        characterController.enabled = false;
        joystick.SetActive(false);
        yield return new WaitForSeconds(2f);
        thisArena.SetActive(false);
        otherArena.SetActive(true);
        Player.transform.position = _targetPoint;
        characterController.enabled = true;
        joystick.SetActive(true);
        LC.Exp += 1;
    }
}
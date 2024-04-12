using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Trigger : MonoBehaviour
{
    public GameObject sword;
    public GameObject attack;
    public GameObject dodge;
    public GameObject block;
    public GameObject trigger;
    public GameObject bowtrigger;
    public GameObject TPtrigger;
    public AudioSource skelSound;
    public WeaponCheck weaponCheck;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "SwordTrigger")
        {
            sword.SetActive(true);
            attack.SetActive(true);
            dodge.SetActive(true);
            trigger.SetActive(false);
            bowtrigger.SetActive(false);
            TPtrigger.SetActive(true);
            skelSound.Play();
            weaponCheck.weapon = "Sword";
        }
    }
}
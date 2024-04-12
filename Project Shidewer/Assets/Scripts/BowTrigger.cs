using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BowTrigger : MonoBehaviour
{
    public GameObject bow;
    public GameObject quiver;
    public GameObject attack;
    public GameObject dodge;
    public GameObject trigger;
    public GameObject swordtrigger;
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
        if (other.tag == "BowTrigger")
        {
            bow.SetActive(true);
            quiver.SetActive(true);
            attack.SetActive(true);
            dodge.SetActive(true);
            trigger.SetActive(false);
            swordtrigger.SetActive(false);
            TPtrigger.SetActive(true);
            skelSound.Play();
            weaponCheck.weapon = "Bow";
        }
    }
}
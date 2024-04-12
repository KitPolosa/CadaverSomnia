using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponArenaCheck : MonoBehaviour
{
    public WeaponCheck WC;
    public GameObject SwordSkill;
    public GameObject BowSkill;
    // Start is called before the first frame update
    void Start()
    {
        if (WC.weapon == "Sword")
        {
            SwordSkill.SetActive(true);
        }
        else if (WC.weapon == "Bow")
        {
            BowSkill.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

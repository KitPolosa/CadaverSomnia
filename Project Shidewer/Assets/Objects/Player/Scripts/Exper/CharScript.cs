using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharScript : MonoBehaviour
{
    public int DamLevel;
    public Text txtDam;
    public Text txtSP;
    public int Value = 0;
    //public static Experience Exp;

    public int HealthLevel;
    public Text txtHealth;

    public GameObject healthBut;
    public GameObject damBut;
    public AttackingMechanicsScript at_mech;
    public HealthPlayer hl_player;
    public SkillsScript SS;
    public SkillsBowScript SBS;
    public HitboxDamage Hitbox;
    public HitBoxDamageCA HitboxCA;
    public HitboxDamageSU HitboxSU;
    public HitboxDamageCRA HitboxCRA;
    public ArrowHitboxDamage ArrHitbox;
    public ArrowHitboxTB ArrHitboxTB;
    public ExplosiveHitbox ArrHitboxEA;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        txtSP.text = Value.ToString();
        if (Value > 0)
        {
            damBut.GetComponent<Button>().interactable = true;
            healthBut.GetComponent<Button>().interactable = true;
        }
    }

    public void DamageCount()
    {
        if (Value > 0)
        {
            DamLevel = DamLevel + 1;
            txtDam.text = DamLevel.ToString();
            //at_mech.damage += 3;
            Hitbox.damage += 8;
            HitboxCA.damage += 10;
            HitboxSU.damage += 8;
            HitboxCRA.damage += 12;
            ArrHitbox.damage += 5;
            ArrHitboxTB.damage += 5;
            ArrHitboxEA.damage += 7;
            --Value;
            --(SS.Value);
            --(SBS.Value);
            txtSP.text = Value.ToString();
        }
        if (int.Parse(txtSP.text) == 0)
        {
            damBut.GetComponent<Button>().interactable = false;
            healthBut.GetComponent<Button>().interactable = false;
        }
    }

    public void HealthCount()
    {
        if (Value > 0)
        {
            HealthLevel = HealthLevel + 1;
            txtHealth.text = HealthLevel.ToString();
            hl_player.healthMax += 35;
            hl_player._health = hl_player.healthMax;
            --Value;
            --(SS.Value);
            --(SBS.Value);
            txtSP.text = Value.ToString();
        }
        if (int.Parse(txtSP.text) == 0)
        {
            damBut.GetComponent<Button>().interactable = false;
            healthBut.GetComponent<Button>().interactable = false;
        }
    }
}
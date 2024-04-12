using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillsScript : MonoBehaviour
{
    public CharScript CS;

    public GameObject panelCA;
    public GameObject panelSA;
    public GameObject panelCRA;

    public GameObject CircAttBuy;
    public GameObject CircAttEquip;
    public GameObject CircAttMark;
    public GameObject CircAttConfPanel;
    public GameObject CircAttConf1;
    public GameObject CircAttConf2;
    public GameObject CAC;
    public GameObject SAC;
    public GameObject CRAC;

    public GameObject StingAttBuy;
    public GameObject StingAttEquip;
    public GameObject StingAttMark;
    public GameObject StingAttConfPanel;
    public GameObject StingAttConf1;
    public GameObject StingAttConf2;

    public GameObject CrowdAttBuy;
    public GameObject CrowdAttEquip;
    public GameObject CrowdAttMark;
    public GameObject CrowdAttConfPanel;
    public GameObject CrowdAttConf1;
    public GameObject CrowdAttConf2;

    public Text txtSP;
    public int Value = 0;

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
            CircAttBuy.GetComponent<Button>().interactable = true;
            StingAttBuy.GetComponent<Button>().interactable = true;
            CrowdAttBuy.GetComponent<Button>().interactable = true;
        }
    }

    public void CircularAttack()
    {
        panelCA.SetActive(true);
        panelSA.SetActive(false);
        panelCRA.SetActive(false);
    }
    public void CircularAttackBuy()
    {
        if (Value > 0)
        {
            CircAttBuy.SetActive(false);
            CircAttEquip.SetActive(true);
            CircAttMark.SetActive(true);
            --Value;
            --(CS.Value);
            txtSP.text = Value.ToString();
        }
        if (int.Parse(txtSP.text) == 0)
        {
            CircAttBuy.GetComponent<Button>().interactable = false;
        }
    }
    public void CircularAttackEquip()
    {
        CircAttConfPanel.SetActive(true);
        CAC.SetActive(true);
    }
    public void CircularAttack1()
    {
        CircAttConf1.SetActive(true);
        CircAttConfPanel.SetActive(false);
        CAC.SetActive(false);
        CircAttConf2.SetActive(false);
        StingAttConf1.SetActive(false);
        CrowdAttConf1.SetActive(false);
    }
    public void CircularAttack2()
    {
        CircAttConf2.SetActive(true);
        CircAttConf1.SetActive(false);
        CAC.SetActive(false);
        StingAttConf2.SetActive(false);
        CircAttConfPanel.SetActive(false);
        CrowdAttConf2.SetActive(false);
    }

    public void StingAttack()
    {
        panelSA.SetActive(true);
        panelCA.SetActive(false);
        panelCRA.SetActive(false);
    }
    public void StingAttackBuy()
    {
        if (Value > 0)
        {
            StingAttBuy.SetActive(false);
            StingAttEquip.SetActive(true);
            StingAttMark.SetActive(true);
            --Value;
            --(CS.Value);
            txtSP.text = Value.ToString();
        }
        if (int.Parse(txtSP.text) == 0)
        {
            StingAttBuy.GetComponent<Button>().interactable = false;
        }
    }
    public void StingAttackEquip()
    {
        StingAttConfPanel.SetActive(true);
        SAC.SetActive(true);
    }
    public void StingAttack1()
    {
        StingAttConf1.SetActive(true);
        StingAttConfPanel.SetActive(false);
        SAC.SetActive(false);
        StingAttConf2.SetActive(false);
        CircAttConf1.SetActive(false);
        CrowdAttConf1.SetActive(false);
    }
    public void StingAttack2()
    {
        StingAttConf2.SetActive(true);
        StingAttConf1.SetActive(false);
        SAC.SetActive(false);
        StingAttConfPanel.SetActive(false);
        CircAttConf2.SetActive(false);
        CrowdAttConf2.SetActive(false);
    }

    public void CrowdAttack()
    {
        panelCRA.SetActive(true);
        panelSA.SetActive(false);
        panelCA.SetActive(false);
    }
    public void CrowdAttackBuy()
    {
        if (Value > 0)
        {
            CrowdAttBuy.SetActive(false);
            CrowdAttEquip.SetActive(true);
            CrowdAttMark.SetActive(true);
            --Value;
            --(CS.Value);
            txtSP.text = Value.ToString();
        }
        if (int.Parse(txtSP.text) == 0)
        {
            CrowdAttBuy.GetComponent<Button>().interactable = false;
        }
    }
    public void CrowdAttackEquip()
    {
        CrowdAttConfPanel.SetActive(true);
        CRAC.SetActive(true);
    }
    public void CrowdAttack1()
    {
        CrowdAttConf1.SetActive(true);
        CrowdAttConfPanel.SetActive(false);
        CRAC.SetActive(false);
        CrowdAttConf2.SetActive(false);
        CircAttConf1.SetActive(false);
        StingAttConf1.SetActive(false);
    }
    public void CrowdAttack2()
    {
        CrowdAttConf2.SetActive(true);
        CrowdAttConf1.SetActive(false);
        CRAC.SetActive(false);
        CrowdAttConfPanel.SetActive(false);
        CircAttConf2.SetActive(false);
        StingAttConf2.SetActive(false);
    }
}
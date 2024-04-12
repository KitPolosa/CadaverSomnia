using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillsBowScript : MonoBehaviour
{
    public CharScript CS;

    public GameObject panelTA;
    public GameObject panelTB;
    public GameObject panelEA;

    public GameObject TAC;
    public GameObject TBC;
    public GameObject EAC;

    public GameObject ThreeArrBuy;
    public GameObject ThreeArrEquip;
    public GameObject ThreeArrMark;
    public GameObject ThreeArrConfPanel;
    public GameObject ThreeArrConf1;
    public GameObject ThreeArrConf2;

    public GameObject ThroughBoomBuy;
    public GameObject ThroughBoomEquip;
    public GameObject ThroughBoomMark;
    public GameObject ThroughBoomConfPanel;
    public GameObject ThroughBoomConf1;
    public GameObject ThroughBoomConf2;

    public GameObject ExplosiveArrowBuy;
    public GameObject ExplosiveArrowEquip;
    public GameObject ExplosiveArrowMark;
    public GameObject ExplosiveArrowConfPanel;
    public GameObject ExplosiveArrowConf1;
    public GameObject ExplosiveArrowConf2;

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
            ThreeArrBuy.GetComponent<Button>().interactable = true;
            ThroughBoomBuy.GetComponent<Button>().interactable = true;
            ExplosiveArrowBuy.GetComponent<Button>().interactable = true;
        }
    }

    public void ThreeArrow()
    {
        panelTA.SetActive(true);
        panelTB.SetActive(false);
        panelEA.SetActive(false);
    }
    public void ThreeArrowBuy()
    {
        if (Value > 0)
        {
            ThreeArrBuy.SetActive(false);
            ThreeArrEquip.SetActive(true);
            ThreeArrMark.SetActive(true);
            --Value;
            --(CS.Value);
            txtSP.text = Value.ToString();
        }
        if (int.Parse(txtSP.text) == 0)
        {
            ThreeArrBuy.GetComponent<Button>().interactable = false;
        }
    }
    public void ThreeArrowEquip()
    {
        ThreeArrConfPanel.SetActive(true);
        TAC.SetActive(true);
    }
    public void ThreeArrow1()
    {
        ThreeArrConf1.SetActive(true);
        ThreeArrConfPanel.SetActive(false);
        TAC.SetActive(false);
        ThreeArrConf2.SetActive(false);
        ThroughBoomConf1.SetActive(false);
        ExplosiveArrowConf1.SetActive(false);
    }
    public void ThreeArrow2()
    {
        ThreeArrConf2.SetActive(true);
        ThreeArrConf1.SetActive(false);
        ThroughBoomConf2.SetActive(false);
        TAC.SetActive(false);
        ExplosiveArrowConf2.SetActive(false);
        ThreeArrConfPanel.SetActive(false);
    }

    public void ThroughBoom()
    {
        panelTB.SetActive(true);
        panelTA.SetActive(false);
        panelEA.SetActive(false);
    }
    public void ThroughBoommBuy()
    {
        if (Value > 0)
        {
            ThroughBoomBuy.SetActive(false);
            ThroughBoomEquip.SetActive(true);
            ThroughBoomMark.SetActive(true);
            --Value;
            --(CS.Value);
            txtSP.text = Value.ToString();
        }
        if (int.Parse(txtSP.text) == 0)
        {
            ThroughBoomBuy.GetComponent<Button>().interactable = false;
        }
    }
    public void ThroughBoommEquip()
    {
        ThroughBoomConfPanel.SetActive(true);
        TBC.SetActive(true);
    }
    public void ThroughBoom1()
    {
        ThroughBoomConf1.SetActive(true);
        ThroughBoomConfPanel.SetActive(false);
        TBC.SetActive(false);
        ThroughBoomConf2.SetActive(false);
        ThreeArrConf1.SetActive(false);
        ExplosiveArrowConf1.SetActive(false);
    }
    public void ThroughBoom2()
    {
        ThroughBoomConf2.SetActive(true);
        ThroughBoomConf1.SetActive(false);
        ThroughBoomConfPanel.SetActive(false);
        TBC.SetActive(false);
        ThreeArrConf2.SetActive(false);
        ExplosiveArrowConf2.SetActive(false);
    }

    public void ExplosiveArrow()
    {
        panelEA.SetActive(true);
        panelTB.SetActive(false);
        panelTA.SetActive(false);
    }
    public void ExplosiveArrowwBuy()
    {
        if (Value > 0)
        {
            ExplosiveArrowBuy.SetActive(false);
            ExplosiveArrowEquip.SetActive(true);
            ExplosiveArrowMark.SetActive(true);
            --Value;
            --(CS.Value);
            txtSP.text = Value.ToString();
        }
        if (int.Parse(txtSP.text) == 0)
        {
            ExplosiveArrowBuy.GetComponent<Button>().interactable = false;
        }
    }
    public void ExplosiveArrowwEquip()
    {
        ExplosiveArrowConfPanel.SetActive(true);
        EAC.SetActive(true);
    }
    public void ExplosiveArrow1()
    {
        ExplosiveArrowConf1.SetActive(true);
        ExplosiveArrowConfPanel.SetActive(false);
        EAC.SetActive(false);
        ExplosiveArrowConf2.SetActive(false);
        ThreeArrConf1.SetActive(false);
        ThroughBoomConf1.SetActive(false);
    }
    public void ExplosiveArrow2()
    {
        ExplosiveArrowConf2.SetActive(true);
        ExplosiveArrowConf1.SetActive(false);
        ExplosiveArrowConfPanel.SetActive(false);
        EAC.SetActive(false);
        ThreeArrConf2.SetActive(false);
        ThroughBoomConf2.SetActive(false);
    }
}
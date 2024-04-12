using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S2RecScript : MonoBehaviour
{
    public GameObject S2Rec;
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CircleAttack()
    {
        S2Rec.SetActive(true);
        StartCoroutine(Timer());
    }

    public IEnumerator Timer()
    {
        yield return new WaitForSeconds(0.1f);
        anim.SetTrigger("PlayS2");
        yield return new WaitForSeconds(10.9f);
        S2Rec.SetActive(false);
    }
}
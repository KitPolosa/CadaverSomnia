using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S1RecScript : MonoBehaviour
{
    public GameObject S1Rec;
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
        S1Rec.SetActive(true);
        StartCoroutine(Timer());
    }
    public IEnumerator Timer()
    {
        yield return new WaitForSeconds(0.1f);
        anim.SetTrigger("PlayS1");
        yield return new WaitForSeconds(10.9f);
        S1Rec.SetActive(false);
    }
}
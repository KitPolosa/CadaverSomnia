using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelTriggerScript : MonoBehaviour
{
    public CharacterController characterController;
    public GameObject SF;
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
        StartCoroutine(Teleport2());
    }

    IEnumerator Teleport2()
    {
        yield return new WaitForSeconds(3f);
        SF.SetActive(false);
        characterController.enabled = true;
    }
}
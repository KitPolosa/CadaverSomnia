using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballRotation : MonoBehaviour
{
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        this.gameObject.transform.Rotate(new Vector3(90.0f, -90.0f, 0.0f));
    }

    // Update is called once per frame
    void Update()
    {
        //transform.rotation = Quaternion.LookRotation(rb.velocity);
        //this.GetComponent<Rigidbody>().AddRelativeForce(new Vector3(0, 0, -15));
    }
}
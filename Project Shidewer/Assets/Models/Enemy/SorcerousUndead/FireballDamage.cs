using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballDamage : MonoBehaviour
{
    public int damage;
    //public AudioSource bowSound;
    public GameObject arr;
    //public AudioSource skelSound;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator ShotTimer()
    {
        yield return new WaitForSeconds(0.1f);
        Destroy(gameObject);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            other.GetComponent<HealthPlayer>().Damage(damage);
            arr.GetComponent<Renderer>().enabled = false;
            //bowSound.Play();
            //StartCoroutine(ShotTimer());
            Destroy(gameObject);
        }
    }
}
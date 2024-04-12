using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball : MonoBehaviour
{
    public int Speed;
    Vector3 lastPos;
    private GameObject FBPrefab;
    public GameObject arr;
    [SerializeField] private float hitCooldown = 1.5f;
    public float cooldown = 0;
    public float attackSpeed = 1f;
    public GameObject FB;
    public GameObject arrpref;
    // Start is called before the first frame update
    void Start()
    {
        FBPrefab = Resources.Load("bow_arrow") as GameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if (cooldown > -0.5)
        {
            cooldown -= Time.deltaTime;
        }
        if (cooldown <= 0)
        {
            //StartCoroutine(Shot());
            //FBPrefab.transform.localScale = new Vector3(3, 3, 5);
            //GameObject newArrow = Instantiate(FBPrefab, transform.position, transform.rotation);
            GameObject newArrow = Instantiate(arrpref, transform.position, transform.rotation);
            Rigidbody rb = newArrow.GetComponent<Rigidbody>();
            rb.velocity = transform.forward * Speed;
            Destroy(newArrow, 2);
            cooldown = hitCooldown * attackSpeed;
        }
    }
    public IEnumerator Shot()
    {
        yield return new WaitForSeconds(0.3f);
        GameObject newArrow = Instantiate(arrpref, transform.position, transform.rotation);
        Rigidbody rb = newArrow.GetComponent<Rigidbody>();
        rb.velocity = transform.forward * Speed;
        Destroy(newArrow, 2);
        cooldown = hitCooldown * attackSpeed;
    }

    //public void Shoot()
    //{
    //    if (cooldown <= 0)
    //    {
    //        //FBPrefab.transform.localScale = new Vector3(3, 3, 5);
    //        //GameObject newArrow = Instantiate(FBPrefab, transform.position, transform.rotation);
    //        GameObject newArrow = Instantiate(arrpref, transform.position, transform.rotation);
    //        Rigidbody rb = newArrow.GetComponent<Rigidbody>();
    //        rb.velocity = transform.forward * Speed;
    //        Destroy(newArrow, 2);
    //        cooldown = hitCooldown * attackSpeed;
    //    }
    //}
}
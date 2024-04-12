using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    public int Speed;
    Vector3 lastPos;
    private GameObject arrowPrefab;
    private GameObject arrowPrefabTB;
    private GameObject arrowPrefabEA;
    public GameObject arr;
    [SerializeField] private float hitCooldown = 1.5f;
    public float cooldown = 0;
    public float attackSpeed = 1f;
    public GameObject player;
    public CharacterMechanics chMech;
    public GameObject arrpref;
    public GameObject arrprefTB;
    public GameObject arrprefEA;
    // Start is called before the first frame update
    void Start()
    {
        arrowPrefab = Resources.Load("bow_arroww") as GameObject;
        arrowPrefabTB = Resources.Load("bow_arrowTB") as GameObject;
        arrowPrefabEA = Resources.Load("bow_arrowEA") as GameObject;
        chMech = player.GetComponent<CharacterMechanics>();
    }

    // Update is called once per frame
    void Update()
    {
        if (cooldown > -0.5)
        {
            cooldown -= Time.deltaTime;
        }
    }

    public void Shoot()
    {
        if (cooldown <= 0/* && chMech.speedMove == 0.3f*/)
        {
            //GameObject newArrow = Instantiate(arrowPrefab) as GameObject;
            GameObject newArrow = Instantiate(arrpref);
            newArrow.transform.position = transform.position;
            Rigidbody rb = newArrow.GetComponent<Rigidbody>();
            rb.velocity = transform.forward * Speed;
            Destroy(newArrow, 2);
            cooldown = hitCooldown * attackSpeed;
        }
    }

    public void ShootTB()
    {
        if (cooldown <= 0/* && chMech.speedMove == 0.3f*/)
        {
            //GameObject newArrow = Instantiate(arrowPrefabTB) as GameObject;
            GameObject newArrow = Instantiate(arrprefTB);
            newArrow.transform.position = transform.position;
            Rigidbody rb = newArrow.GetComponent<Rigidbody>();
            rb.velocity = transform.forward * Speed;
            Destroy(newArrow, 2);
            cooldown = hitCooldown * attackSpeed;
        }
    }

    public void ShootEA()
    {
        if (cooldown <= 0/* && chMech.speedMove == 0.3f*/)
        {
            //GameObject newArrow = Instantiate(arrowPrefabEA) as GameObject;
            GameObject newArrow = Instantiate(arrprefEA);
            newArrow.transform.position = transform.position;
            Rigidbody rb = newArrow.GetComponent<Rigidbody>();
            rb.velocity = transform.forward * Speed;
            Destroy(newArrow, 2);
            cooldown = hitCooldown * attackSpeed;
        }
    }
}
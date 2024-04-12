using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SUScript : MonoBehaviour
{
    //public GameObject Fireball;
    //private Fireball FB;
    //public GameObject player;
    //public GameObject checker;
    //public Transform target;
    //public float dist;
    //public float range;
    //public float atRange;
    //NavMeshAgent myAgent;
    //Animator myAnim;
    //public HealthPlayer PlayerH;
    //private GDHealth EnemyH;

    //private Animator ch_animator;
    //// Start is called before the first frame update
    //void Start()
    //{
    //    myAgent = GetComponent<NavMeshAgent>();
    //    myAnim = GetComponent<Animator>();
    //    EnemyH = GetComponent<GDHealth>();
    //    FB = Fireball.GetComponent<Fireball>();
    //}

    //// Update is called once per frame
    //void Update()
    //{
    //    dist = Vector3.Distance(/*checker.*/transform.position, target.transform.position);
    //    if (dist > range)
    //    {
    //        myAgent.enabled = false;
    //        myAnim.SetBool("Idle", true);
    //        myAnim.SetBool("Move", false);
    //        myAnim.SetBool("Attack", false);
    //    }
    //    //if (dist <= range & dist > atRange)
    //    //{
    //    //    myAgent.enabled = true;
    //    //    myAgent.SetDestination(target.position);
    //    //    myAnim.SetBool("Idle", false);
    //    //    myAnim.SetBool("Move", true);
    //    //    myAnim.SetBool("Attack", false);
    //    //}
    //    //if (dist <= atRange)
    //    //{
    //    //    StartCoroutine(Attack());
    //    //}
    //    if (PlayerH._health <= 0)
    //    {
    //        atRange = 0;
    //    }
    //    if (EnemyH._health < 0)
    //    {
    //        myAgent.enabled = false;
    //    }
    //}

    //public IEnumerator Attack()
    //{
    //    yield return new WaitForSeconds(0.5f);
    //    myAgent.enabled = false;
    //    myAnim.SetBool("Idle", false);
    //    myAnim.SetBool("Move", false);
    //    myAnim.SetBool("Attack", true);
    //    FB.Shoot();
    //}

    //void OnTriggerStay(Collider col)
    //{
    //    if (col.tag == "Player")
    //    {
    //        //gameObject.GetComponent<Animator>().SetBool("Attack", true);
    //        StartCoroutine(Attack());
    //        transform.LookAt(col.transform.position);
    //        transform.eulerAngles = new Vector3(0, transform.eulerAngles.y, 0);
    //    }
    //}
    //void OnTriggerExit(Collider col)
    //{
    //    if (col.tag == "Player")
    //    {
    //        myAgent.enabled = true;
    //        myAgent.SetDestination(target.position);
    //        myAnim.SetBool("Idle", false);
    //        myAnim.SetBool("Move", true);
    //        myAnim.SetBool("Attack", false);
    //        //gameObject.GetComponent<Animator>().SetBool("Attack", false);
    //    }
    //}
}
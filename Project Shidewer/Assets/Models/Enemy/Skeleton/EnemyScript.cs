using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyScript : MonoBehaviour
{
    public GameObject player;
    public GameObject checker;
    public Transform target;
    public double dist;
    public double range;
    public double atRange;
    public double atRange2;
    NavMeshAgent myAgent;
    Animator myAnim;
    public HealthPlayer PlayerH;
    private HealthEnemy EnemyH;
    public Transform playr;
    public bool atflag = true;
    private HealthPlayer playerHealth;

    private Animator ch_animator;
    public void Start()
    {
        myAgent = GetComponent<NavMeshAgent>();
        myAnim = GetComponent<Animator>();
        EnemyH = GetComponent<HealthEnemy>();
        playerHealth = GetComponent<HealthPlayer>();
    }

    // Update is called once per frame
    void Update()
    {
        dist = (Vector3.Distance(checker.transform.position, target.transform.position));
        if (dist > range)
        {
            myAgent.enabled = false;
            myAnim.SetBool("Idle", true);
            myAnim.SetBool("Run", false);
            myAnim.SetBool("Attack", false);
        }
        if (dist <= range & dist > atRange)
        {
            myAgent.enabled = true;
            myAgent.SetDestination(target.position);
            myAnim.SetBool("Idle", false);
            myAnim.SetBool("Run", true);
            myAnim.SetBool("Attack", false);
        }
        if (dist <= atRange)
        {
            StartCoroutine(Attack());
        }
        if (PlayerH._health <= 0)
        {
            atRange = 0;
            atflag = false;
            myAgent.enabled = false;
        }
        if (EnemyH._health < 0)
        {
            myAgent.enabled = false;
        }
    }

    public IEnumerator Attack()
    {
        yield return new WaitForSeconds(0.1f);
        myAgent.enabled = false;
        myAnim.SetBool("Idle", false);
        myAnim.SetBool("Run", false);
        transform.LookAt(playr);
        myAnim.SetBool("Attack", true);
    }
}
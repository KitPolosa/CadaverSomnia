using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyScript2 : MonoBehaviour
{
    public GameObject colliderGameObject;
    public GameObject player;
    public GameObject checker;
    public Transform target;
    public float dist;
    public float range;
    public float atRange;
    NavMeshAgent myAgent;
    Animator myAnim;
    public HealthPlayer PlayerH;
    private HealthEnemy EnemyH;
    public bool atflag = false;
    public Transform playr;
    // Start is called before the first frame update
    void Start()
    {
        myAgent = GetComponent<NavMeshAgent>();
        myAnim = GetComponent<Animator>();
        EnemyH = GetComponent<HealthEnemy>();
    }

    // Update is called once per frame
    void Update()
    {
        dist = Vector3.Distance(checker.transform.position, target.transform.position);
        if (dist > range && atflag == false)
        {
            myAgent.enabled = false;
            myAnim.SetBool("Idle", true);
            myAnim.SetBool("Run", false);
            myAnim.SetBool("Attack", false);
        }
        if (dist <= range & dist > atRange && atflag == false)
        {
            myAgent.enabled = true;
            myAgent.SetDestination(target.position);
            myAnim.SetBool("Idle", false);
            myAnim.SetBool("Run", true);
            myAnim.SetBool("Attack", false);
        }
        if (dist <= atRange && atflag == true)
        {
            StartCoroutine(Attack());
        }
        if (PlayerH._health <= 0)
        {
            atRange = 0;
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
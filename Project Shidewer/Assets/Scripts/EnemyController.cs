using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    public float disWalk, disAttack;
    public int healthMonster;

    private NavMeshAgent _agent;
    private Animator anim;
    private GameObject Player;

    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        _agent = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();
    }


    void Update()
    {
        if(healthMonster <= 0)
        {
            Destroy (gameObject);
        }
        float dis = Vector3.Distance(Player.transform.position, transform.position);

        if (dis <= disWalk && dis > disAttack)
        {
            _agent.isStopped = false;
            _agent.SetDestination(Player.transform.position);
            anim.SetFloat("Move", 1);
        }
        else
        {
            _agent.isStopped = true;
            anim.SetFloat("Move", 0);
        }

        if (dis <= disAttack)
        {
            anim.SetBool("Attack", true);
        }
        else
        {
            anim.SetBool("Attack", false);
        }
    }
}

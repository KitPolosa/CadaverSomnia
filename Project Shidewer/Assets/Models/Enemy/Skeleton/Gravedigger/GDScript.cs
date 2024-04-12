using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class GDScript : MonoBehaviour
{
    public Transform playr;
    public GameObject FBbox;
    public GameObject Fireball;
    private Fireball FB;
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
    private GDHealth EnemyH;
    public bool atflag = false;
    public AudioSource bowSound;
    private HealthPlayer playerHealth;

    private Animator ch_animator;
    // Start is called before the first frame update
    void Start()
    {
        myAgent = GetComponent<NavMeshAgent>();
        myAnim = GetComponent<Animator>();
        EnemyH = GetComponent<GDHealth>();
        FB = Fireball.GetComponent<Fireball>();
        playerHealth = player.GetComponent<HealthPlayer>();
    }

    // Update is called once per frame
    void Update()
    {
        //transform.LookAt(playr);
        dist = Vector3.Distance(checker.transform.position, target.transform.position);
        if (dist > range && atflag == false)
        {
            myAgent.enabled = false;
            myAnim.SetBool("Idle", true);
            myAnim.SetBool("Move", false);
            myAnim.SetBool("Attack", false);
        }
        if (dist <= range & dist > atRange && atflag == false)
        {
            myAgent.enabled = true;
            myAgent.SetDestination(target.position);
            myAnim.SetBool("Idle", false);
            myAnim.SetBool("Move", true);
            myAnim.SetBool("Attack", false);
        }
        if (dist <= atRange && atflag == true)
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
        yield return new WaitForSeconds(0.5f);
        bowSound.Play();
        myAgent.enabled = false;
        myAnim.SetBool("Idle", false);
        myAnim.SetBool("Move", false);
        transform.LookAt(playr);
        myAnim.SetBool("Attack", true);
    }

    void OnTriggerStay(Collider col)
    {
        if (col.tag == "Player")
        {
            //gameObject.GetComponent<Animator>().SetBool("Attack", true);
            StartCoroutine(Attack());
            transform.LookAt(col.transform.position);
            transform.eulerAngles = new Vector3(0, transform.eulerAngles.y, 0);
        }
    }
    void OnTriggerExit(Collider col)
    {
        if (col.tag == "Player")
        {
            myAgent.enabled = true;
            myAgent.SetDestination(target.position);
            myAnim.SetBool("Idle", false);
            myAnim.SetBool("Move", true);
            myAnim.SetBool("Attack", false);
            //gameObject.GetComponent<Animator>().SetBool("Attack", false);
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwordAttack : MonoBehaviour
{
    [SerializeField] private GameObject enemyPanel;
    private Slider enemyHealth;
    private Text enemyName;
    private Animator anim;
    private AttackingMechanicsScript attack;

    [SerializeField] private int damage = 1;
    public float attackDistance = 1f;
    public float attackSpeed = 1f;

    private List<HealthEnemy> enemies = new List<HealthEnemy>(); //Список объектов в пределах видимости
    public HealthEnemy currentEnemy; //текущий залоченный враг
    [SerializeField] private float lockDistance = 10f; //Радиус видимости противников

    [SerializeField] public float hitCooldown = 1.5f;
    public float cooldown = 0;
    void Start()
    {
        enemyHealth = enemyPanel.GetComponentInChildren<Slider>();
        enemyName = enemyPanel.GetComponentInChildren<Text>();
        //anim = GetComponent<Animator>();
    }

    void Update()
    {
        Found();

        //if (anim.GetBool("AttackContinue"))
        //    Attack();

        //if (cooldown > -0.5)
        //{
        //    cooldown -= Time.deltaTime;

        //    if (cooldown <= 0)
        //    {
        //        anim.SetBool("Attack", false);
        //    }
        //}
    }

    public void Found()
    {
        Collider[] objects = Physics.OverlapSphere(transform.position, lockDistance); //Поиск противников внутри сферы определённого радиуса.

        enemies.Clear();

        foreach (Collider obj in objects)
        {
            HealthEnemy enemy = obj.gameObject.GetComponent<HealthEnemy>();

            if (enemy != null)  //Если на объекте есть компонент HealthEnemy...
            {
                enemies.Add(enemy); //Он добавляется в список

                RaycastHit hit;

                if (Physics.Raycast(transform.position, enemy.transform.position, out hit))
                {
                    if (hit.transform != enemy.transform) //Но если луч от игрока не доходит до него..
                    {
                        enemies.Remove(enemy); //Он удаляется
                    }
                }
            }
        } //Отсеивание ненужных объектов

        float minDistan = lockDistance * lockDistance; //Минимальная дистанция в квадрате

        if (enemies.Count != 0)
        {
            for (int i = 0; i < enemies.Count; i++)
            {
                float dista = (transform.position - enemies[i].transform.position).sqrMagnitude; //Дистанция до противника в квадрате(так легче компуктеру)

                if (dista < minDistan && enemies[i] != null) //Ближе ли он чем предыдущий
                {
                    minDistan = dista;
                    currentEnemy = enemies[i];
                }
            }
        }
        if (enemies.Count == 0)
        {
            enemyPanel.SetActive(false);
            //anim.SetBool("isLocked", false);
        }
        else/* if (!anim.GetBool("Dodge"))*/
        {
            enemyPanel.SetActive(true);
            enemyName.text = currentEnemy.enemyName;
            enemyHealth.maxValue = currentEnemy.healthMax;
            enemyHealth.value = currentEnemy.health;
        }
    }

    //public void Attack()
    //{
    //    if (!anim.GetBool("Dodge") && cooldown <= 0)
    //    {
    //        anim.SetBool("Attack", true);
    //        anim.SetBool("Move", false);
    //        anim.SetBool("AttackContinue", false);

    //        cooldown = hitCooldown * attackSpeed;

    //        StartCoroutine(Swattack.AttackProcess());
    //    }
    //    else if (cooldown < hitCooldown) //В случае если прошло больше половины кулдауна(attackSpeed / 2)
    //        anim.SetBool("AttackContinue", true); //Запуск следующей анимации атаки
    //}

    public IEnumerator AttackProcess()
    {
        yield return new WaitForSeconds(attack.cooldown / 2);


        if (currentEnemy != null)
        {
            if ((currentEnemy.transform.position - transform.position).sqrMagnitude < attackDistance * attackDistance)
                currentEnemy.Damage(damage);
        }
    }
}

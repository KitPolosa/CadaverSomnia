using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AttackingMechanicsScript : MonoBehaviour
{
    //[SerializeField] private GameObject enemyPanel;
    //private Slider enemyHealth;
    //private Text enemyName;
    private Animator anim;
    //public GameObject Target1;
    //public GameObject Target2;
    public GameObject Hitbox;
    public GameObject Arrow_hb;
    public GameObject PointerBow;
    public GameObject RunSource;

    //[SerializeField] private float lockDistance = 10f; //Радиус видимости противников

    //private List<HealthEnemy> enemies = new List<HealthEnemy>(); //Список объектов в пределах видимости

    //public HealthEnemy currentEnemy; //текущий залоченный враг
    [SerializeField] private Arrow arrow; //Скрипт стрелы

    private CharacterMechanics ch_mech;

    [SerializeField] public int damage = 1;
    public float attackDistance = 1f;
    public float attackSpeed = 1f;

    [SerializeField] private float hitCooldown = 1.5f;
    public float cooldown = 0;

    [SerializeField] private float shotCooldown = 1.5f;
    public float shcooldown = 0;

    private void Start()
    {
        //enemyHealth = enemyPanel.GetComponentInChildren<Slider>();
        //enemyName = enemyPanel.GetComponentInChildren<Text>();
        anim = GetComponent<Animator>();
        arrow = GetComponent<Arrow>();
        ch_mech = GetComponent<CharacterMechanics>();
    }


    private void Update()
    {
        //Found();

        if (anim.GetBool("AttackContinue"))
            Attack();

        if (cooldown > -0.5)
        {
            cooldown -= Time.deltaTime;

            if (cooldown <= 0)
            {
                anim.SetBool("Attack", false);
            }
        }
        if (cooldown > -0.5)
        {
            cooldown -= Time.deltaTime;

            if (cooldown <= 0)
            {
                anim.SetBool("CircleAttack", false);
            }
        }
    }

    //public void FoundEnemies()
    //{
    //    Target1.SetActive(false);
    //    Target2.SetActive(true);
    //    Collider[] objects = Physics.OverlapSphere(transform.position, lockDistance); //Поиск противников внутри сферы определённого радиуса.

    //    enemies.Clear();

    //    foreach (Collider obj in objects)
    //    {
    //        HealthEnemy enemy = obj.gameObject.GetComponent<HealthEnemy>();

    //        if (enemy != null)  //Если на объекте есть компонент HealthEnemy...
    //        {
    //            enemies.Add(enemy); //Он добавляется в список

    //            RaycastHit hit;

    //            if (Physics.Raycast(transform.position, enemy.transform.position, out hit))
    //            {
    //                if (hit.transform != enemy.transform) //Но если луч от игрока не доходит до него..
    //                {
    //                    enemies.Remove(enemy); //Он удаляется
    //                }
    //            }
    //        }
    //    } //Отсеивание ненужных объектов

    //    float minDist = lockDistance * lockDistance; //Минимальная дистанция в квадрате

    //    if (enemies.Count != 0)
    //    {
    //        for (int i = 0; i < enemies.Count; i++)
    //        {
    //            float dist = (transform.position - enemies[i].transform.position).sqrMagnitude; //Дистанция до противника в квадрате(так легче компуктеру)

    //            if (dist < minDist && enemies[i] != null) //Ближе ли он чем предыдущий
    //            {
    //                minDist = dist;
    //                currentEnemy = enemies[i];
    //            }
    //        }
    //    }


    //    if (enemies.Count == 0)
    //    {
    //        Target2.SetActive(false);
    //        Target1.SetActive(true);
    //        enemyPanel.SetActive(false);
    //        anim.SetBool("isLocked", false);
    //    }
    //    else if (!anim.GetBool("Dodge"))
    //    {
    //        enemyPanel.SetActive(true);
    //        enemyName.text = currentEnemy.enemyName;
    //        enemyHealth.maxValue = currentEnemy.healthMax;
    //        enemyHealth.value = currentEnemy.health;
    //        anim.SetBool("isLocked", true);
    //    }
    //}

    //public void FoundFalse()
    //{
    //    enemyPanel.SetActive(false);
    //    anim.SetBool("isLocked", false);
    //    Target2.SetActive(false);
    //    Target1.SetActive(true);
    //}

    //public void Found()
    //{
    //    Collider[] objects = Physics.OverlapSphere(transform.position, lockDistance); //Поиск противников внутри сферы определённого радиуса.

    //    enemies.Clear();

    //    foreach (Collider obj in objects)
    //    {
    //        HealthEnemy enemy = obj.gameObject.GetComponent<HealthEnemy>();

    //        if (enemy != null)  //Если на объекте есть компонент HealthEnemy...
    //        {
    //            enemies.Add(enemy); //Он добавляется в список

    //            RaycastHit hit;

    //            if (Physics.Raycast(transform.position, enemy.transform.position, out hit))
    //            {
    //                if (hit.transform != enemy.transform) //Но если луч от игрока не доходит до него..
    //                {
    //                    enemies.Remove(enemy); //Он удаляется
    //                }
    //            }
    //        }
    //    } //Отсеивание ненужных объектов

    //    float minDistan = lockDistance * lockDistance; //Минимальная дистанция в квадрате

    //    if (enemies.Count != 0)
    //    {
    //        for (int i = 0; i < enemies.Count; i++)
    //        {
    //            float dista = (transform.position - enemies[i].transform.position).sqrMagnitude; //Дистанция до противника в квадрате(так легче компуктеру)

    //            if (dista < minDistan && enemies[i] != null) //Ближе ли он чем предыдущий
    //            {
    //                minDistan = dista;
    //                currentEnemy = enemies[i];
    //            }
    //        }
    //    }
    //    if (enemies.Count == 0)
    //    {
    //        Target2.SetActive(false);
    //        Target1.SetActive(true);
    //        enemyPanel.SetActive(false);
    //        anim.SetBool("isLocked", false);
    //    }
    //    else if (!anim.GetBool("Dodge"))
    //    {
    //        enemyPanel.SetActive(true);
    //        enemyName.text = currentEnemy.enemyName;
    //        enemyHealth.maxValue = currentEnemy.healthMax;
    //        enemyHealth.value = currentEnemy.health;
    //    }
    //}

    public void Attack()
    {
        if (!anim.GetBool("Dodge") && cooldown <= 0)
        {
            anim.SetBool("Attack", true);
            anim.SetBool("Move", false);
            anim.SetBool("AttackContinue", false);

            cooldown = hitCooldown * attackSpeed;
        }
        else if (cooldown < hitCooldown) //В случае если прошло больше половины кулдауна(attackSpeed / 2)
            anim.SetBool("AttackContinue", true); //Запуск следующей анимации атаки
    }

    public void CircleAttack()
    {
        if (!anim.GetBool("Dodge") && cooldown <= 0)
        {
            anim.SetBool("CircleAttack", true);
            anim.SetBool("Move", false);

            cooldown = hitCooldown * attackSpeed;
        }
    }

    public void Shot()
    {
        if (!anim.GetBool("Dodge")/* && !anim.GetBool("Move")*/ && cooldown <= 0)
        {
            anim.SetBool("Move", false);
            PointerBow.SetActive(true);
            anim.SetBool("Shot", true);
            if (anim.GetBool("Shot"))
            {
                ch_mech.speedMove = 0f;
            }
            RunSource.SetActive(false);
            shcooldown = shotCooldown * attackSpeed;
        }
    }

    public void Shoting()
    {
        PointerBow.SetActive(false);
        anim.SetBool("Shot", false);
        anim.SetBool("Move", true);
        RunSource.SetActive(true);
        StartCoroutine(ShotProcess());
        //StartCoroutine(ShotTimer());
        ch_mech.speedMove = 7f;
    }

    public IEnumerator ShotTimer()
    {
        yield return new WaitForSeconds(0.1f);
        ch_mech.speedMove = 7f;
    }

    IEnumerator AttackProcess(GameObject hitbox)
    {
        yield return new WaitForSeconds(cooldown / 2);

        if (hitbox.transform.tag == "Enemy")
        {
            if (hitbox.transform.GetComponent<HealthEnemy>() != null)
                hitbox.transform.GetComponent<HealthEnemy>().Damage(damage);
        }
    }

    private IEnumerator ShotProcess()
    {
        yield return new WaitForSeconds(cooldown / 2);
    }
}
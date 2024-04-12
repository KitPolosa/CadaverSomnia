using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine.UI;
using UnityEngine;
using System.Globalization;

[RequireComponent(typeof(Rigidbody), typeof (BoxCollider))]
public class CharacterMechanics : MonoBehaviour
{
    public float speedMove;//скорость персонажа
    [SerializeField] private float dodgeTime = 1.25f;//длительность анимации уворота
    [SerializeField] private float dodgeSpeed = 10;//Добавочная величина к длительности уворота
    private Vector3 movevector;//направление движения персонажа
    [SerializeField] private Rigidbody _rigidbody;
    public GameObject RunAudio;
    public AudioSource RunSource;
    public float stopThreshold = 0.01f;

    //Ссылки компоненты
    private CharacterController ch_controller;
    private Animator ch_animator;
    private AttackingMechanicsScript attack;
    [SerializeField] private MobileController moveContr;

    public float attackSpeed = 1f;

    [SerializeField] private float hitCooldown = 1.5f;
    public float cooldown = 0;
    [SerializeField] private FixedJoystick _joystick;

    public AudioSource vzmahSound;
    public float rotationSpeed = 180f; // скорость вращения в градусах в секунду
    public float rotationInputSensitivity = 1f; // чувствительность ввода вращения
    private float accumulatedRotation = 0f; // Накопленное вращение

    private void Start()
    {
        ch_controller = GetComponent<CharacterController>();
        ch_animator = GetComponent<Animator>();
        attack = GetComponent<AttackingMechanicsScript>();
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        CharacterMove();
        if (Input.GetKeyDown(KeyCode.Space))
            Dodge();
        Dodging();
        if (Input.GetKeyDown(KeyCode.E))
            Sting();
        StingAtt();
        if (cooldown > -0.5)
        {
            cooldown -= Time.deltaTime;

            if (cooldown <= 0)
            {
                ch_animator.SetBool("StingAttack", false);
            }
        }
        if (Input.GetKeyDown(KeyCode.C))
            Crowd();
        CrowdAtt();
        if (cooldown > -0.5)
        {
            cooldown -= Time.deltaTime;

            if (cooldown <= 0)
            {
                ch_animator.SetBool("CrowdAttack", false);
            }
        }
    }

    //метод перемещения персонажа
    private void CharacterMove()
    {
        //movevector = Vector3.zero;
        //movevector.x = moveContr.inputVector.x * speedMove;
        //movevector.z = moveContr.inputVector.y * speedMove;
        //movevector = Quaternion.Euler(0, 45, 0) * movevector;
        //if (movevector.x != 0 || movevector.z != 0)
        //{
        //    if ((ch_animator.GetBool("Attack") || ch_animator.GetBool("Dodge") || ch_animator.GetBool("Block") || ch_animator.GetBool("CircleAttack")/* || ch_animator.GetBool("Shot")*/) == false)
        //    {
        //        ch_animator.SetBool("Move", true);
        //        RunSource.enabled = true;
        //    }
        //}
        //else
        //{
        //    ch_animator.SetBool("Move", false);
        //    RunSource.enabled = false;
        //    //transform.rotation = Quaternion.LookRotation(_rigidbody.velocity);
        //}
        //if (ch_animator.GetBool("Move"))
        //{
        //    if ((Vector3.Angle(Vector3.forward, movevector) > 1f || Vector3.Angle(Vector3.forward, movevector) == 0) && !ch_animator.GetBool("isLocked"))
        //    {   //Поворот персонажа по направлению движения
        //        Vector3 direct = Vector3.RotateTowards(transform.forward, movevector, speedMove, 0.0f);
        //        direct = Vector3.Lerp(transform.forward, direct, Time.deltaTime * 20);
        //        transform.rotation = Quaternion.LookRotation(direct);
        //        //transform.rotation = Quaternion.LookRotation(_rigidbody.velocity);
        //    }

        //    ch_controller.Move(movevector * Time.deltaTime);//метод передвижения по направлению
        //}

        if (_joystick.Horizontal != 0 || _joystick.Vertical != 0)
        {
            if ((ch_animator.GetBool("Attack") && ch_animator.GetBool("Dodge") && ch_animator.GetBool("Block") && ch_animator.GetBool("CircleAttack") && ch_animator.GetBool("StingAttack") && ch_animator.GetBool("CrowdAttack")/* || ch_animator.GetBool("Shot")*/) == false)
            {
                ch_animator.SetBool("Move", true);
                RunSource.enabled = true;
            }
        }
        else
        {
            ch_animator.SetBool("Move", false);
            RunSource.enabled = false;
        }
        if (ch_animator.GetBool("Shot") || ch_animator.GetBool("Attack") || ch_animator.GetBool("Dodge") || ch_animator.GetBool("Block") || ch_animator.GetBool("CircleAttack") || ch_animator.GetBool("StingAttack") || ch_animator.GetBool("CrowdAttack") == true)
        {
            ch_animator.SetBool("Move", false);
        }
        if (!ch_animator.GetBool("Dodge") && !ch_animator.GetBool("Attack") && !ch_animator.GetBool("StingAttack") && !ch_animator.GetBool("CrowdAttack"))
        {
            Vector3 moveVector = new Vector3(_joystick.Horizontal, 0, _joystick.Vertical);
            moveVector = Quaternion.Euler(0, Camera.main.transform.eulerAngles.y, 0) * moveVector;
            if (moveVector.magnitude > stopThreshold)
            {
                // Поворот персонажа по направлению движения
                transform.rotation = Quaternion.LookRotation(moveVector);

                // Применение передвижения через CharacterController
                ch_controller.Move(moveVector * speedMove * Time.deltaTime);
            }
            else
            {
                // Если скорость меньше порогового значения, прерываем анимацию бега
                ch_animator.SetBool("Move", false);
                RunSource.enabled = false;
            }
        }

        //_rigidbody.velocity = new Vector3(_joystick.Horizontal * speedMove, _rigidbody.velocity.y, _joystick.Vertical * speedMove);

            //if (_joystick.Horizontal != 0 || _joystick.Vertical != 0)
            //{
            //    Vector3 direct = Vector3.RotateTowards(transform.forward, movevector, speedMove, 0.0f);
            //    direct = Vector3.Lerp(transform.forward, direct, Time.deltaTime * 20);
            //    transform.rotation = Quaternion.LookRotation(_rigidbody.velocity);
            //}

            //Vector3 moveVector = new Vector3(_joystick.Horizontal, 0, _joystick.Vertical);
            //moveVector = Quaternion.Euler(0, Camera.main.transform.eulerAngles.y, 0) * moveVector; // Поворот вектора движения относительно направления камеры
            //if (moveVector.magnitude > 0.01f)
            //{
            //    // Поворот персонажа по направлению движения
            //    transform.rotation = Quaternion.LookRotation(moveVector);
            //}
            //// Применение передвижения через CharacterController
            //ch_controller.Move(moveVector * speedMove * Time.deltaTime);
    }


    private float dodgeTimer; //таймер до окончания уворота
    public void Dodge() //начало уворота
    {
        if (/*!ch_animator.GetBool("Attack") && */!ch_animator.GetBool("Dodge"))
        {
            ch_animator.SetBool("Attack", false);
            ch_animator.SetBool("Shot", false);
            ch_animator.SetBool("AttackContinue", false);
            ch_animator.SetBool("Dodge", true);
            ch_animator.SetBool("Move", false);

            dodgeTimer = dodgeTime;

            if (movevector != Vector3.zero)
                transform.forward = movevector;
        }
    }
    private void Dodging() //кадр, в котором персонаж уворачивается
    {
        if (ch_animator.GetBool("Dodge"))
        {

            if (dodgeTimer <= 0)
                ch_animator.SetBool("Dodge", false);
            else
            {
                float mult;
                if (dodgeTimer <= dodgeTime / 2)
                    mult = dodgeTimer / (dodgeTime / 2);
                else
                    mult = (dodgeTime - dodgeTimer) / (dodgeTime / 2); //Высчитывание множителя для более плавного уворота

                ch_controller.Move(transform.forward * Time.deltaTime * mult * dodgeSpeed); //добавление скорости для уворота
                dodgeTimer -= Time.deltaTime;
            }
        }
    }

    public void Sting() //начало уворота
    {
        if (!ch_animator.GetBool("Dodge") &&  cooldown <= 0)
        {
            ch_animator.SetBool("Attack", false);
            ch_animator.SetBool("Shot", false);
            ch_animator.SetBool("AttackContinue", false);
            ch_animator.SetBool("StingAttack", true);
            ch_animator.SetBool("Move", false);

            dodgeTimer = dodgeTime;

            cooldown = hitCooldown * attackSpeed;

            if (movevector != Vector3.zero)
                transform.forward = movevector;
        }
    }
    private void StingAtt() //кадр, в котором персонаж уворачивается
    {
        if (ch_animator.GetBool("StingAttack"))
        {

            if (dodgeTimer <= 0)
                ch_animator.SetBool("StingAttack", false);
            else
            {
                float mult;
                if (dodgeTimer <= dodgeTime / 2)
                    mult = dodgeTimer / (dodgeTime / 2);
                else
                    mult = (dodgeTime - dodgeTimer) / (dodgeTime / 2); //Высчитывание множителя для более плавного уворота

                ch_controller.Move(transform.forward * Time.deltaTime * mult * dodgeSpeed); //добавление скорости для уворота
                dodgeTimer -= Time.deltaTime;
                vzmahSound.Play();
            }
        }
    }

    public void Crowd() //начало уворота
    {
        if (!ch_animator.GetBool("Dodge") && cooldown <= 0)
        {
            ch_animator.SetBool("Attack", false);
            ch_animator.SetBool("Shot", false);
            ch_animator.SetBool("AttackContinue", false);
            ch_animator.SetBool("CrowdAttack", true);
            ch_animator.SetBool("Move", false);

            dodgeTimer = dodgeTime;

            cooldown = hitCooldown * attackSpeed;

            if (movevector != Vector3.zero)
                transform.forward = movevector;
        }
    }
    private void CrowdAtt() //кадр, в котором персонаж уворачивается
    {
        if (ch_animator.GetBool("CrowdAttack"))
        {

            if (dodgeTimer <= 0)
                ch_animator.SetBool("CrowdAttack", false);
            else
            {
                float mult;
                if (dodgeTimer <= dodgeTime / 2)
                    mult = dodgeTimer / (dodgeTime / 2);
                else
                    mult = (dodgeTime - dodgeTimer) / (dodgeTime / 2); //Высчитывание множителя для более плавного уворота

                ch_controller.Move(transform.forward * Time.deltaTime * mult * dodgeSpeed); //добавление скорости для уворота
                dodgeTimer -= Time.deltaTime;
                vzmahSound.Play();
            }
        }
    }

    public void Block()
    {
        if (!ch_animator.GetBool("Dodge"))
        {
            ch_animator.SetBool("Attack", false);
            ch_animator.SetBool("Shot", false);
            ch_animator.SetBool("AttackContinue", false);
            ch_animator.SetBool("Dodge", false);
            ch_animator.SetBool("Move", false);
            ch_animator.SetBool("Block", true);
        }
    }

    public void Blocking()
    {
        //ch_animator.SetBool("Attack", true);
        //ch_animator.SetBool("AttackContinue", true);
        ch_animator.SetBool("Dodge", true);
        ch_animator.SetBool("Move", true);
        ch_animator.SetBool("Block", false);
    }

    /*
    private void GetInput()
    {
        Vector3 attackvector = Quaternion.Euler(0, 45, 0) * new Vector3(attackContr.inputVector.x, 0, attackContr.inputVector.y);

        if (attackvector.magnitude != 0)
        {
            if (ch_animator.GetBool("Move") == true)
            {
                ch_animator.SetBool("Move", false);
                ch_animator.SetInteger("condition", 0);
            }
            if (ch_animator.GetBool("Move") == false)
            {
                transform.forward = attackvector;
                Attacking();
            }
        }
    }
    */
    private void Attacking()
    {
        StartCoroutine(AttackRoutine());
    }

    IEnumerator AttackRoutine()
    {
        ch_animator.SetBool("Attack", true);
        ch_animator.SetInteger("condition", 2);
        yield return new WaitForSeconds(1);
        ch_animator.SetInteger("condition", 0);
        ch_animator.SetBool("Attack", false);
    }
}

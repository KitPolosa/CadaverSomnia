using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthPlayer : MonoBehaviour
{
    public MobileController StopMove;
    public GameObject joystick;
    public GameObject attack1;
    public GameObject attack2;
    public GameObject attack3;
    public GameObject attack4;
    public GameObject attack5;
    public GameObject attack6;
    public GameObject attack7;
    public GameObject attack8;
    public GameObject attack9;
    public GameObject attack10;
    public GameObject attack11;
    public GameObject attack12;
    public GameObject attack13;
    public GameObject attack14;
    public GameObject dodge;
    public GameObject DeathMessage;
    public int healthMax;
    public int _health;
    private CharacterController characterController;
    public GameObject screenFader;
    public GameObject menuButton;
    public GameObject LC;
    public GameObject EC;
    public GameObject TC;
    public AudioSource deathPlay;
    public Timer tlag;

    public int health
    { get { return _health; } }

    [SerializeField] private Slider healthSlider;
    [SerializeField] private Animator anim;

    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
        _health = healthMax;
        characterController = GetComponent<CharacterController>();
    }


    public void Damage(int damage)
    {
        healthSlider.maxValue = healthMax;
        _health -= damage;

        healthSlider.value = _health;
        if (_health <= 0)
        {
            StopMove.StopMove();
            characterController.enabled = false;
            joystick.SetActive(false);
            attack1.SetActive(false);
            attack2.SetActive(false);
            attack3.SetActive(false);
            attack4.SetActive(false);
            attack5.SetActive(false);
            attack6.SetActive(false);
            attack7.SetActive(false);
            attack8.SetActive(false);
            attack9.SetActive(false);
            attack10.SetActive(false);
            attack11.SetActive(false);
            attack12.SetActive(false);
            attack13.SetActive(false);
            attack14.SetActive(false);
            dodge.SetActive(false);
            anim.SetTrigger("Dead");
            screenFader.SetActive(true);
            DeathMessage.SetActive(true);
            deathPlay.Play();
            Timer otherScript = tlag.GetComponent<Timer>();
            otherScript.timerflag = false;
            StartCoroutine(TimeScale());
        }
    }

    public void Heal(int heal)
    {
        healthSlider.maxValue = healthMax;
        _health = _health + heal;

        healthSlider.value = _health;
        if (_health > healthMax)
        {
            _health = healthMax;
        }
    }

    private IEnumerator TimeScale()
    {
        yield return new WaitForSeconds(7.5f);
        Time.timeScale = 0f;
        AudioListener.pause = true;
        menuButton.SetActive(true);
        LC.SetActive(true);
        EC.SetActive(true);
        TC.SetActive(true);
    }
}
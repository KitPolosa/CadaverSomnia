using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthEnemy : MonoBehaviour
{
    public CharacterController _characterController;
    private EnemyScript EnScr;
    public string enemyName = "Skeleton";
    Animator myAnim;

    public int healthMax;

    public Experience Exper;
    public CharScript CS;
    public SkillsScript SS;
    public SkillsBowScript SBS;
    public int expUp;
    [SerializeField] private Slider ExpSlider;
    public int ExpMax;
    public GameObject damBut;
    public GameObject healthBut;
    [SerializeField] private Slider healthSlider;
    [SerializeField] private Canvas canvas;
    public GameObject SkeletonSpawn;
    public AudioSource deathSound;
    private ExitTriggerScript exitTrigger;
    public GameObject newPoint;
    public GameObject soundPoint;
    public LevelCount LC;

    public int _health;
    public int health
    { get { return _health; } }


    private void Start()
    {
        EnScr = GetComponent<EnemyScript>();
        _characterController = GetComponent<CharacterController>();
        myAnim = GetComponent<Animator>();
        _health = healthMax;
        exitTrigger = GameObject.Find("ExitTrigger").GetComponent<ExitTriggerScript>();
    }


    public void Damage(int damage)
    {
        healthSlider.maxValue = healthMax;
        _health -= damage;
        healthSlider.value = _health;
        if (_health - damage > 0)
        {
            myAnim.SetTrigger("Hit");
        }
        else if (_health <= 0)
        {
            myAnim.SetTrigger("Dead");
            ExpSlider.maxValue = ExpMax;
            //Exper.Exp += expUp;
            ExpSlider.value += expUp;
            if (ExpSlider.value == ExpSlider.maxValue)
            {
                SS.Value += expUp;
                SBS.Value += expUp;
                CS.Value += expUp;
                Exper.Exp += expUp;
                ExpSlider.value = 0;
                damBut.GetComponent<Button>().interactable = true;
                healthBut.GetComponent<Button>().interactable = true;
                ScreenExit otherScript2 = newPoint.GetComponent<ScreenExit>();
                otherScript2.ScrrenFade();
                SoundEffect otherScript3 = soundPoint.GetComponent<SoundEffect>();
                otherScript3.PlayThosSoundEffect3();
            }
            LC.En += 1;
            transform.gameObject.tag = "Untagged";
            EnScr.enabled = false;
            _characterController.enabled = false;
            deathSound.Play();
            exitTrigger.EnemyDefeated();
            Destroy(SkeletonSpawn, 2.5f);
            //Destroy(this.gameObject, 2.6f);
        }
    }

    void Update()
    {
        if (canvas.transform.rotation != Camera.main.transform.rotation)
        {
            canvas.transform.rotation = Camera.main.transform.rotation;
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GDHealth2 : MonoBehaviour
{
    public CharacterController _characterController;
    private GDScript2 EnScr;
    public string enemyName = "Gravedigger";
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
    public GameObject newPoint;
    public GameObject soundPoint;
    public LevelCount LC;
    private ExitTriggerScript exitTrigger;

    public int _health;
    public int health
    { get { return _health; } }
    // Start is called before the first frame update
    void Start()
    {
        EnScr = GetComponent<GDScript2>();
        _characterController = GetComponent<CharacterController>();
        myAnim = GetComponent<Animator>();
        _health = healthMax;
        exitTrigger = GameObject.Find("ExitTrigger").GetComponent<ExitTriggerScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (canvas.transform.rotation != Camera.main.transform.rotation)
        {
            canvas.transform.rotation = Camera.main.transform.rotation;
        }
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
            myAnim.SetTrigger("Death");
            ExpSlider.maxValue = ExpMax;
            //Exper.Exp += expUp;
            ExpSlider.value += expUp;
            if (ExpSlider.value == ExpSlider.maxValue)
            {
                Exper.Exp += expUp;
                SS.Value += expUp;
                SBS.Value += expUp;
                CS.Value += expUp;
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
        }
    }
}
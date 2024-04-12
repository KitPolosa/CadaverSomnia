using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SUHealth : MonoBehaviour
{
    public CharacterController _characterController;
    private GDScript EnScr;
    public string enemyName = "Sourcerer Undead";
    Animator myAnim;

    public int healthMax;

    public Experience Exper;
    public CharScript CS;
    public SkillsScript SS;
    public int expUp;
    [SerializeField] private Slider ExpSlider;
    public int ExpMax;
    public GameObject damBut;
    public GameObject healthBut;
    [SerializeField] private Slider healthSlider;
    [SerializeField] private Canvas canvas;

    public int _health;
    public int health
    { get { return _health; } }
    // Start is called before the first frame update
    void Start()
    {
        EnScr = GetComponent<GDScript>();
        _characterController = GetComponent<CharacterController>();
        myAnim = GetComponent<Animator>();
        _health = healthMax;
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
                SS.Value += expUp;
                Exper.Exp += expUp;
                CS.Value += expUp;
                ExpSlider.value = 0;
                damBut.GetComponent<Button>().interactable = true;
                healthBut.GetComponent<Button>().interactable = true;
            }
            transform.gameObject.tag = "Untagged";
            EnScr.enabled = false;
            _characterController.enabled = false;
            Destroy(gameObject, 2.5f);
        }
    }
}
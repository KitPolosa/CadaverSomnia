using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelCount : MonoBehaviour
{
    public int Exp;
    public int En;
    public Text txtExp;
    public Text Tim;
    public Text Count;
    public Text Enemy;
    public Text Timer1;
    public Text Count2;
    public Text Enemy2;
    public Text Timer2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Timer otherScript = Tim.GetComponent<Timer>();
        txtExp.text = Exp.ToString();
        Count.text = txtExp.text;
        Enemy.text = En.ToString();
        CopyTextValue(Tim, Timer1);
        Count2.text = txtExp.text;
        Enemy2.text = En.ToString();
        CopyTextValue(Tim, Timer2);
    }

    void CopyTextValue(Text source, Text destination)
    {
        // Проверяем, что оба объекта Text существуют
        if (source != null && destination != null)
        {
            // Копируем текст
            destination.text = source.text;
        }
        else
        {
            Debug.LogError("Не удалось скопировать текст. Убедитесь, что оба объекта Text назначены.");
        }
    }
}
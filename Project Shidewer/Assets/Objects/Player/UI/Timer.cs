using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    private int sec = 0;
    private int min = 0;
    public Text timerText;
    private int delta = 1;
    public bool timerflag = true;
    // Start is called before the first frame update
    void Start()
    {
        timerText = GameObject.Find("timer").GetComponent<Text>();
        StartCoroutine(TimerFlow());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator TimerFlow()
    {
        while (timerflag == true)
        {
            while (true)
            {
                if (sec == 59)
                {
                    min++;
                    sec = -1;
                }
                sec += delta;
                timerText.text = min.ToString("D2") + " : " + sec.ToString("D2");
                yield return new WaitForSeconds(1);
            }
    }
        if (timerflag == false)
        {
            this.delta = 0;
        }
    }
}
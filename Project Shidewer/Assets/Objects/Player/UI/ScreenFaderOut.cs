using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScreenFaderOut : MonoBehaviour
{
    public float fadeSpeed = 0.5f;

    void Update()
    {
        
    }

    //void Start()
    //{
    //    // Начать с затемнения
    //    StartCoroutine(FadeInAndOut());
    //}

    public void ScrrenFade()
    {
        StartCoroutine(FadeInAndOut());
    }

    IEnumerator FadeInAndOut()
    {
        Image fadeImage = GetComponent<Image>();
        Color color = fadeImage.color;
        while (color.a < 1f)
        {
            color.a += fadeSpeed * Time.deltaTime;
            fadeImage.color = color;
            yield return null;
        }
        color.a = 1f;
        fadeImage.color = color;

        while (color.a > 0f)
        {
            color.a -= fadeSpeed * Time.deltaTime;
            fadeImage.color = color;
            yield return null;
        }
        color.a = 0f;
        fadeImage.color = color;

        yield return new WaitForSeconds(0.5f);
        this.gameObject.SetActive(false);
    }
}
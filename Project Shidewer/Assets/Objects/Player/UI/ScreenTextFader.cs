using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScreenTextFader : MonoBehaviour
{
    public float fade_speed = 0.3f;
    // Start is called before the first frame update
    IEnumerator Start()
    {
        Text fade_image = GetComponent<Text>();
        Color color = fade_image.color;
        while (color.a < 1f)
        {
            color.a += fade_speed * Time.deltaTime;
            fade_image.color = color;
            yield return null;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

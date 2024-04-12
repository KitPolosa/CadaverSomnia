using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class InstantDialogue : MonoBehaviour
{
    public TextAsset asset;

    int i = 0;

    public Text dialogue_Text;
    public GameObject panel;
    public Dialog dialog;
    public Image character_image;

    public int[] char_ID;
    public Sprite[] char_Sprites;

    Dialog dialogue;

    public GameObject NextButton;
    public GameObject CloseButton;
    public GameObject joystick;
    public GameObject dodge;

    // Start is called before the first frame update
    void Start()
    {
        dialogue = Dialog.Load(asset);
    }

    // Update is called once per frame
    void Update()
    {
        dialogue_Text.text = dialogue.nodes[i].text;
            if (dialogue.nodes[i].end != "true")
            {
                joystick.SetActive(true);
                dodge.SetActive(true);
                panel.SetActive(false); ;
                for (int j = 0; j < dialogue.nodes.Length; j++)
                {
                }
            }
            else
            {
                NextButton.SetActive(true);
            }
        character_image.sprite = char_Sprites[char_ID[i]];
    }

    public void Next(int nextNode, string end)
    {
        if (i < dialogue.nodes.Length - 1)
        {
            if (dialogue.nodes[i].end == "true")
                i++;
            else
            {
                if (end != "true")
                {
                    i = nextNode;
                }
            }
        }
        else if (i == dialogue.nodes.Length - 1)
        {
            i = dialogue.nodes.Length - 1;
        }
    }

    public void NextB()
    {
        Next(0, "");
    }
}
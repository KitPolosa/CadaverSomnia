using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class InventoryScript : MonoBehaviour
{
    [SerializeField] private GameObject invWindow;

    [SerializeField] private Transform content;

    [SerializeField] private Text DescriptionText;

    public void OpenInventory()
    {
        invWindow.SetActive(true);
    }

    public void CloseInventory()
    {
        DescriptionText.text = "";
        invWindow.SetActive(false);
    }

    public void OpenDescription(string text)
    {
        DescriptionText.text = text;
    }

    public void AddItem(GameObject item)
    {
        GameObject itemInstance = Instantiate(item, content); //вызывается из ItemOnLevelScript, создаёт копию item в content - элементе слайдера внутри инвентаря
    }
}

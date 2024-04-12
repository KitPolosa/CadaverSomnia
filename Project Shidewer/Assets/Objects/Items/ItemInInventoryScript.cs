using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemInInventoryScript : MonoBehaviour
{
    public string testDescription = "Hello, World!";

    public void DisplayDescription()
    {
        GameObject.Find("Inventory Button").GetComponent<InventoryScript>().OpenDescription(testDescription);
    }
}

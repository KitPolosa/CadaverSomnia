using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemOnLevelScript : MonoBehaviour
{
    public GameObject itemInInventory;

    private void OnMouseDown()
    {
        GameObject.Find("Inventory Button").GetComponent<InventoryScript>().AddItem(itemInInventory);
        Destroy(gameObject);
    }
}

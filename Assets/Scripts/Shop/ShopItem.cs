using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopItem : MonoBehaviour
{
    public string itemName;
    public int price;

    public ShopItem(string itemName, int price)
    {
        this.itemName = itemName;
        this.price = price;
    }
    // You can add more fields as needed

    // Add methods or events related to the shop item if necessary
}

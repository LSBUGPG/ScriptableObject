using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    public ItemDatabase database;

    void Start()
    {
        foreach (Item item in database.items)
        {
            Debug.LogFormat("{0} {1} coins", item.name, item.price);
        }    
    }
}

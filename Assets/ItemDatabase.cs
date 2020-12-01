using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Item
{
    public string name;
    public int price;
}

[CreateAssetMenu]
public class ItemDatabase : ScriptableObject
{
    public List<Item> items;
}

using System;
using UnityEngine;

public enum ItemType
{
    Ak,
    Ar,
    Hp,
    Ciri
}

[Serializable]
public class Item
{
    public Sprite Icon {  get; private set; }
    public int status {  get; private set; }
    public ItemType Type { get; private set; }
    public Item(Sprite icon,int status, ItemType type)
    {
        this.Icon = icon;
        this.status = status;
        this.Type = type;
    }
}

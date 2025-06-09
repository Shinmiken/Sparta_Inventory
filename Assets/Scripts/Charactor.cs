using System;
using System.Collections.Generic;

[Serializable]
public class Charactor
{
    public string Name { get; private set; }
    public int Level { get; private set; }
    public int Attack { get; private set; }
    public int Armor { get; private set; }
    public int Health { get; private set; }
    public int Critical { get; private set; }
    public int Gold { get; private set; }

    public List<Item> Inventory { get; private set; }
    public Charactor(string name, int level, int attack, int armor, int health, int critical, int gold, List<Item> inventory)
    {
        this.Name = name;
        this.Level = level;
        this.Attack = attack;
        this.Armor = armor;
        this.Health = health;
        this.Critical = critical;
        this.Gold = gold;
        this.Inventory = inventory;
    }

    public void Additem(Item item)
    {
        Inventory.Add(item);
    }

    public void Equip(Item item)
    {
        switch(item.Type)
        {
            case ItemType.Ak:
                Attack += item.status;
                break;
            case ItemType.Ar:
                Armor += item.status;
                break;
            case ItemType.Hp:
                Health += item.status; 
                break;
            case ItemType.Ciri:
                Critical += item.status;
                break;
            default:
                break;
        }
    }

    public void UnEquip(Item item)
    {
        switch (item.Type)
        {
            case ItemType.Ak:
                Attack -= item.status;
                break;
            case ItemType.Ar:
                Armor -= item.status;
                break;
            case ItemType.Hp:
                Health -= item.status;
                break;
            case ItemType.Ciri:
                Critical-= item.status;
                break;
            default:
                break;
        }
    }
}

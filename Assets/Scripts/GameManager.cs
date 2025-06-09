using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance {  get; private set; }
    public Charactor player {  get; private set; }
    [SerializeField] private Sprite swordIcon;
    [SerializeField] private Sprite shieldIcon;
    [SerializeField] private Sprite HpIcon;
    [SerializeField] private Sprite CiriIcon;

    private void Awake()
    {
        instance = this;
        SetData();
    }

    public void SetData()
    {
        List<Item> items = new List<Item>();
        items.Add(new Item(swordIcon, 10, ItemType.Ak));
        items.Add(new Item(shieldIcon, 5, ItemType.Ar));
        items.Add(new Item(HpIcon, 10, ItemType.Hp));
        items.Add(new Item(CiriIcon, 5, ItemType.Ciri));
        items.Add(new Item(swordIcon, 10, ItemType.Ak));
        items.Add(new Item(swordIcon, 10, ItemType.Ak));
        items.Add(new Item(swordIcon, 10, ItemType.Ak));
        items.Add(new Item(swordIcon, 10, ItemType.Ak));
        items.Add(new Item(swordIcon, 10, ItemType.Ak));
        items.Add(new Item(swordIcon, 10, ItemType.Ak));
        items.Add(new Item(swordIcon, 10, ItemType.Ak));


        player = new Charactor("½ÅÇÑºû", 10, 35, 40, 100, 25, 20000, items);

        UIManager.Instance.uiMainMenu.SetInfo(player);
        UIManager.Instance.uiStatus.SetInfo(player);
    }

}

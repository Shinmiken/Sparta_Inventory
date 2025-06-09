using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIInventory : MonoBehaviour
{
    [SerializeField] private UISlot inventorySlot;
    [SerializeField] private Transform slotTransform;
    [SerializeField] private Button button;

    private List<UISlot> slots = new List<UISlot>();

    void Start()
    {
        button.onClick.AddListener(UIManager.Instance.uiMainMenu.OpenInventory);
        InitInventoryUI();
    }

    public void InitInventoryUI()
    {
        var inventory = GameManager.instance.player.Inventory;

        for(int i = 0; i < inventory.Count; i++)
        {
            UISlot slot = Instantiate(inventorySlot, slotTransform);
            slot.SetItem(inventory[i]);
            slots.Add(slot);
        }
    }
}

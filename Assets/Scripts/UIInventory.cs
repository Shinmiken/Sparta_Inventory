using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIInventory : MonoBehaviour
{
    [SerializeField] private UISlot inventorySlot;
    [SerializeField] private Transform slotTransform;
    [SerializeField] private TextMeshProUGUI inventoryText;
    [SerializeField] private Button button;

    private List<UISlot> slots = new List<UISlot>();
    public int cnt = 0;

    void Start()
    {
        button.onClick.AddListener(UIManager.Instance.uiMainMenu.OpenInventory);
    }

    public void InitInventoryUI() // 장비 인벤토리 창에 추가
    {
        UISlot slot = Instantiate(inventorySlot, slotTransform);
        slot.SetItem(GameManager.instance.player.Inventory[cnt]);
        slots.Add(slot);
        cnt++;
        inventoryText.text = "Inventory " + cnt.ToString() + " / 120";
    }
}

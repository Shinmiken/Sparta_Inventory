using UnityEngine;
using UnityEngine.UI;

public class UISlot : MonoBehaviour
{
    [SerializeField] private Image icon;

    private Item itemData;

    [SerializeField] private GameObject eButton;

    public void SetItem(Item item)
    {
        itemData = item;
        RefreshUI();
    }

    public void RefreshUI()
    {
        // 아이콘이 있다면 설정
        if (icon != null && itemData.Icon != null)
            icon.sprite = itemData.Icon;
    }

    public void OnClick() // 장비 장착 해제
    {
        if (eButton.activeSelf)
        {
            GameManager.instance.player.UnEquip(itemData);
            eButton.SetActive(false);
        }
        else
        {
            GameManager.instance.player.Equip(itemData);
            eButton.SetActive(true);
        }
        UIManager.Instance.uiStatus.SetInfo(GameManager.instance.player);
    }
}

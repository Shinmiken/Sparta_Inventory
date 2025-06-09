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
        // �������� �ִٸ� ����
        if (icon != null && itemData.Icon != null)
            icon.sprite = itemData.Icon;
    }

    public void OnClick()
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

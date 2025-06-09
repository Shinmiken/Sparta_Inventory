using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIMainMenu : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI[] UItext;
    [SerializeField] private Button[] button;
    void Start()
    {
        button[0].onClick.AddListener(OpenMainMenu);
        button[1].onClick.AddListener(OpenMainMenu);
    }
    public void SetInfo(Charactor player)
    {
        UItext[0].text = $"{player.Name}";
        UItext[1].text = $"{player.Level}";
        UItext[2].text = string.Format("{0:N0}", player.Gold);
        UItext[3].text = $"{player.Attack}";
        UItext[4].text = $"{player.Armor}";
        UItext[5].text = $"{player.Health}";
        UItext[6].text = $"{player.Critical}";
    }
    public void OpenMainMenu()
    {
        UIManager.Instance.uiMainMenu.gameObject.SetActive(true);
        if (UIManager.Instance.Status.activeSelf)
        {
            UIManager.Instance.Status.SetActive(false);
            return;
        }
        else
        {
            UIManager.Instance.Inventory.SetActive(false);
            return;
        }
    }

    public void OpenStatus()
    {
        UIManager.Instance.Status.SetActive(true);
        UIManager.Instance.uiMainMenu.gameObject.SetActive(false);
    }

    public void OpenInventory()
    {
        UIManager.Instance.Inventory.gameObject.SetActive(true);
        UIManager.Instance.uiMainMenu.gameObject.SetActive(false);
    }
}

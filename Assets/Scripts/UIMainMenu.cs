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
    public void SetInfo(Charactor player) // 텍스트 UI최신화
    {
        UItext[0].text = $"{player.Name}";
        UItext[1].text = $"{player.Level}";
        UItext[2].text = string.Format("{0:N0}", player.Gold);
        UItext[3].text = $"{player.Attack}";
        UItext[4].text = $"{player.Armor}";
        UItext[5].text = $"{player.Health}";
        UItext[6].text = $"{player.Critical}";
    }
    public void OpenMainMenu() // 메뉴 열기
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
    public void OpenDungeon() // 장비 획득
    {
        if (UIManager.Instance.uiInventory.cnt == 120) // 인벤토리 최대
        {
            Debug.Log("Full");
            return;
        }
            int num = Random.Range(0, 4);
        switch (num)
        {
            case 0:
                GameManager.instance.player.Additem(new Item(GameManager.instance.swordIcon, 10, ItemType.Ak));
                Debug.Log("ak");
                break;
            case 1:
                GameManager.instance.player.Additem(new Item(GameManager.instance.shieldIcon, 5, ItemType.Ar));
                Debug.Log("ar");
                break;
            case 2:
                GameManager.instance.player.Additem(new Item(GameManager.instance.HpIcon, 10, ItemType.Hp));
                Debug.Log("hp");
                break;
            case 3:
                GameManager.instance.player.Additem(new Item(GameManager.instance.CiriIcon, 5, ItemType.Ciri));
                Debug.Log("cr");
                break;
            default:
                break;
        }
        UIManager.Instance.uiInventory.InitInventoryUI();
    }

    public void OpenStatus() // 스테이터스 창 열기
    {
        UIManager.Instance.Status.SetActive(true);
        UIManager.Instance.uiMainMenu.gameObject.SetActive(false);
    }

    public void OpenInventory() // 인벤토리 열기
    {
        UIManager.Instance.Inventory.gameObject.SetActive(true);
        UIManager.Instance.uiMainMenu.gameObject.SetActive(false);
    }
}

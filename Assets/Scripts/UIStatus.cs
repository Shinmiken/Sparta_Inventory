using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIStatus : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI[] UItext;
    [SerializeField] private Button button;
    void Start()
    {
        button.onClick.AddListener(UIManager.Instance.uiMainMenu.OpenStatus);
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
}

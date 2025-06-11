using UnityEngine;
using UnityEngine.UI;

public class UI_Dungeon : MonoBehaviour
{
    [SerializeField] private Button button;
    void Start()
    {
        button.onClick.AddListener(UIManager.Instance.uiMainMenu.OpenDungeon); // 버튼 연결
    }

}

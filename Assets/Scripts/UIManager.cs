using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameObject MainMenu;
    [SerializeField] public GameObject Status;
    [SerializeField] public GameObject Inventory;
    [SerializeField] public GameObject dungeon;

    public static UIManager Instance {  get; private set; }

    public UIMainMenu uiMainMenu { get; private set; }
    public UI_Dungeon uiDungeon { get; private set; }
    public UIStatus uiStatus { get; private set; }
    public UIInventory uiInventory { get; private set; }

    private void Awake()
    {
        Instance = this;
        uiMainMenu = MainMenu.GetComponent<UIMainMenu>();
        uiDungeon = dungeon.GetComponent<UI_Dungeon>();
        uiStatus = Status.GetComponentInParent<UIStatus>();
        uiInventory = Inventory.GetComponentInParent<UIInventory>();
    }
}

using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance {  get; private set; }
    public Charactor player {  get; private set; }
    public Sprite swordIcon;
    public Sprite shieldIcon;
    public Sprite HpIcon;
    public Sprite CiriIcon;

    private void Awake()
    {
        instance = this;
        SetData(); // 초반 데이터 및 UI 설정
    }

    public void SetData() // 초반 데이터 및 UI 설정
    {
        List<Item> items = new List<Item>();


        player = new Charactor("신한빛", 10, 35, 40, 100, 25, 20000, items);

        UIManager.Instance.uiMainMenu.SetInfo(player);
        UIManager.Instance.uiStatus.SetInfo(player);
    }

}

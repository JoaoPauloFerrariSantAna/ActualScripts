using System;
using UnityEngine;
using TMPro;

public class GuiMoneyLoader : MonoBehaviour
{
    private static GuiMoneyLoader mStance;
    public static GuiMoneyLoader gInstance => mStance;

    public TextMeshProUGUI currentMoney;
    public TextMeshProUGUI currentDay;

    public void Start()
    {
        mStance = this;
    }

    void Update()
    {
        this.currentDay.text = GameManager.gInstance.GetFormatedDay().ToString();
        this.currentMoney.text = Math.Round(GameManager.gInstance.mPlayer.GetMoney(), 2).ToString();
    }
}

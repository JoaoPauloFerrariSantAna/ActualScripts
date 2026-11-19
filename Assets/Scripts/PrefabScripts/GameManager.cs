using System;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager mStance;
    public static GameManager gInstance => mStance;

    public TextMeshProUGUI currentMoney;
    public TextMeshProUGUI currentDay;

    public Player mPlayer;
    public House mHouse;

    public static float IncrementAmount { get; private set; } = Constants.InitialMoneyEarned;

    public static int HousesSold { get; private set; } = 0;

    // NOTE: maybe a money manager
    public float PriceToFurnishHouse { get; private set; } = InitialValues.InitialPriceToFurnish;

    void Start()
    {
        mStance = this;
        this.DaysPassed = DataTransferers.gInstance.GetWorkedDays();
    }

    public void UpdatePlayerMoney()
    {
        this.mPlayer.UpdateMoney(InitialValues.InitialMoneyEarned);
        DataTransferers.gInstance.SetPlayerMoney(this.mPlayer.GetMoney());
    }

    public void UpdateMoneyOnGui()
    {
        this.currentMoney.text = this.mPlayer.GetMoney().ToString();
    }

    public int GetFormatedDay()
    {
        return (int)this.DaysPassed + 1;
    }

    public void PassDayTime()
    {
        this.DaysPassed += InitialValues.AmountToPassTime;
        this.currentDay.text = this.GetFormatedDay().ToString();
        DataTransferers.gInstance.SetWorkedDays(this.GetFormatedDay());
    }

    public void UpdatePriceToFurnishIt()
    {
        this.PriceToFurnishHouse /= InitialValues.FurnishPriceMultiplier;
    }
}

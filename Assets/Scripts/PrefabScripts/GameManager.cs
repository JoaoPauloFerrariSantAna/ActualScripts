using System;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager mStance;
    public static GameManager gInstance => mStance;

    public Player mPlayer;
    public House mHouse;

    public static float IncrementAmount { get; private set; } = Constants.InitialMoneyEarned;

    public static int HousesSold { get; private set; } = 0;

    // NOTE: maybe create a TimeManager...?
    public static float DaysPassed { get; private set; } = Constants.InitialDay;
    public static float MaxDays { get; private set; } = Constants.MaxInGameDays;

    void Start()
    {
        mStance = this;
        DataTransferer.gInstance.SetCurrentDay(this.GetFormatedDay());
    }

    void Update()
    {
        DataStatisticTransferer.gInstance.SetCurrentDay(this.GetFormatedDay());
        DataStatisticTransferer.gInstance.SetHousesSold(HousesSold);
        DataStatisticTransferer.gInstance.SetPlayerMoney((float)Math.Round(this.mPlayer.GetMoney(), 2));
        DataStatisticTransferer.gInstance.SetPlayerBankAccount((float)Math.Round(this.mPlayer.GetBankAccount(), 2));
    }

    public void UpdateAmountOfHousesSold()
    {
        HousesSold++;
    }

    public int GetFormatedDay()
    {
        return (int)DaysPassed + 1;
    }

    public void PassDayTime()
    {
        DaysPassed += Constants.AmountToPassTime;
    }

    public void UpdatePriceToFurnishIt()
    {
        this.PriceToFurnishHouse /= InitialValues.FurnishPriceMultiplier;
    }
}

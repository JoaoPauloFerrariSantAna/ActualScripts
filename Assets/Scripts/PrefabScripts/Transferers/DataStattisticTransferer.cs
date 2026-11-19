using UnityEngine;

public class DataStatisticTransferer : MonoBehaviour
{
    private static DataStatisticTransferer mStance;
    public static DataStatisticTransferer gInstance => mStance;

    private float PlayerMoney;
    private float PlayerBankAccount;
    private float CurrentDay;
    private int HousesSold;

    private void Awake()
    {
        if (mStance == null)
        {
            mStance = this;
            DontDestroyOnLoad(this.gameObject);
        }
    }

    public void SetPlayerBankAccount(float money)
    {
        this.PlayerBankAccount = money;
    }

    public float GetPlayerBankAccount()
    {
        return this.PlayerBankAccount;
    }

    public void SetPlayerMoney(float currentPlayerMoney)
    {
        this.PlayerMoney = currentPlayerMoney;
    }

    public float GetPlayerMoney()
    {
        return this.PlayerMoney;
    }

    public void SetCurrentDay(float currentday)
    {
        this.CurrentDay = currentday;
    }

    public float GetCurrentDay()
    {
        return this.CurrentDay;
    }

    public void SetHousesSold(int houses)
    {
        this.HousesSold = houses;
    }

    public int GetHousesSold()
    {
        return this.HousesSold;
    }
}

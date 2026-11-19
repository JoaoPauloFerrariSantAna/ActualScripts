using UnityEngine;

public class DataTransferer : MonoBehaviour
{
    private static DataTransferer mStance;
    public static DataTransferer gInstance => mStance;

    private float PlayerMoney;
    private float CurrentDay;

    private void Awake()
    {
        if (mStance == null)
        {
            mStance = this;
            DontDestroyOnLoad(this.gameObject);
        }
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
}

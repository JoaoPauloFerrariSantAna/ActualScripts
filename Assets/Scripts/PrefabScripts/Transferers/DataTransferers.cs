using UnityEngine;

public class DataTransferers : MonoBehaviour
{
    private static DataTransferers mInstance;
    public static DataTransferers gInstance => mInstance;

    private float mPlayerMoney;
    private int mPlayerWorkDay;

    private void Awake()
    {
        if (mInstance == null)
        {
            mInstance = this;
            DontDestroyOnLoad(this.gameObject);
        }
    }

    public void SetPlayerMoney(float amount)
    {
        this.mPlayerMoney = amount;
    }

    public void SetWorkedDays(int day)
    {
        this.mPlayerWorkDay = day;
    }

    public float GetPlayerMoney()
    {
        return this.mPlayerMoney;
    }

    public int GetWorkedDays()
    {
        return this.mPlayerWorkDay;
    }
}

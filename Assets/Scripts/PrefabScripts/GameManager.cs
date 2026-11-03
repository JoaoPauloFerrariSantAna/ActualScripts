using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    private static GameManager mStance;
    public static GameManager gInstance => mStance;

    public TextMeshProUGUI currentMoney;
    public TextMeshProUGUI currentDay;

    public Player mPlayer;
    
    // NOTE: maybe create a TimeManager...?
    public float DaysPassed { get; private set; } = InitialValues.InitialDay;

    void Start()
    {
        mStance = this;
    }

    public void UpdatePlayerMoney()
    {
        this.mPlayer.UpdateMoney(InitialValues.InitialMoneyEarned);
        DataTransferer.gInstance.SetPlayerMoney(this.mPlayer.GetMoney());
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
        DataTransferer.gInstance.SetCurrentDay(this.GetFormatedDay());
    }
}

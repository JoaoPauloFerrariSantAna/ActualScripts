using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    private static GameManager mStance;
    public static GameManager gInstance => mStance;

    [SerializeField]
    private TextMeshProUGUI currentMoney;

    [SerializeField]
    private TextMeshProUGUI currentDay;

    // NOTE: maybe create a TimeManager...?
    public float DaysPassed { get; private set; } = InitialValues.InitialDay;

    [SerializeField]
    private Player mPlayer;

    void Start()
    {
        mStance = this;
    }

    public void UpdatePlayerMoney()
    {
        this.mPlayer.UpdateMoney(InitialValues.InitialMoneyEarned);
    }

    public void UpdateMoneyOnGui()
    {
        this.currentMoney.text = this.mPlayer.GetMoney().ToString();
    }

    public void PassDayTime()
    {
        this.DaysPassed += InitialValues.AmountToPassTime;
        this.currentDay.text = ((int)this.DaysPassed + 1).ToString();
    }
}

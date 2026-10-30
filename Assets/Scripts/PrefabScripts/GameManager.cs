using UnityEditor;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager mStance;
    public static GameManager gInstance => mStance;

    // NOTE: maybe create a TimeManager...?
    private float DaysPassed = 0;

    [SerializeField]
    private Player mPlayer;

    void Start()
    {
        mStance = this;
    }

    //void Update()
    //{
    //}

    public void UpdatePlayerMoney()
    {
        this.mPlayer.Money += InitialValues.InitialMoneyEarned;
    }

    public void PassDayTime()
    {
        this.DaysPassed += InitialValues.AmountToPassTime;
    }
}

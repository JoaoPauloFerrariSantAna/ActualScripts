using UnityEngine;

public class EarnMoneyBehaviour : MonoBehaviour
{
    public void EarnMoney()
    {
        GameManager.gInstance.UpdatePlayerMoney();
        GameManager.gInstance.PassDayTime();
    }
}
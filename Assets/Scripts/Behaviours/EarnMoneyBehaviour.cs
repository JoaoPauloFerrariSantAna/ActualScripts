using UnityEngine;
using UnityEngine.UI;

public class EarnMoneyBehaviour : MonoBehaviour
{
    private Button button;

    private void Start()
    {
        this.button = this.GetComponent<Button>();
    }

    private void Update()
    {
        if ((int)GameManager.DaysPassed == GameManager.MaxDays)
        {
            this.button.interactable = false;
        }
    }

    public void EarnMoney()
    {
        GameManager.gInstance.mPlayer.UpdateMoney(GameManager.IncrementAmount);
        GameManager.gInstance.PassDayTime();
        DataTransferer.gInstance.SetPlayerMoney(GameManager.gInstance.mPlayer.GetMoney());
    }
}
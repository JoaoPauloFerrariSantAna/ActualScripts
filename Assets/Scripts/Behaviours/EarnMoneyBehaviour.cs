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
        if ((int)GameManager.gInstance.DaysPassed == InitialValues.MaxInGameDays)
        {
            this.button.interactable = false;
        }
    }

    public void EarnMoney()
    {
        GameManager.gInstance.UpdatePlayerMoney();
        GameManager.gInstance.UpdateMoneyOnGui();
        GameManager.gInstance.PassDayTime();
    }
}
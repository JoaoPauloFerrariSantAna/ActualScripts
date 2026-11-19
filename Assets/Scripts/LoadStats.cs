using TMPro;
using UnityEngine;

public class LoadStats : MonoBehaviour
{
    public TextMeshProUGUI currentMoney;
    public TextMeshProUGUI currentBankAccount;
    public TextMeshProUGUI currentDay;
    public TextMeshProUGUI housesSold;

    public void Start()
    {
        this.currentMoney.text = DataStatisticTransferer.gInstance.GetPlayerMoney().ToString();
        this.currentBankAccount.text = DataStatisticTransferer.gInstance.GetPlayerBankAccount().ToString();
        this.currentDay.text = DataStatisticTransferer.gInstance.GetCurrentDay().ToString();
        this.housesSold.text = DataStatisticTransferer.gInstance.GetHousesSold().ToString();
    }
}

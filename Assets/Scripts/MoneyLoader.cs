using TMPro;
using UnityEngine;

public class DataShopLoader : MonoBehaviour
{
    public TextMeshProUGUI currentMoney;
    public TextMeshProUGUI currentDay;

    void Start()
    {
        this.currentMoney.text = DataTransferers.gInstance.GetPlayerMoney().ToString();
        this.currentDay.text = DataTransferers.gInstance.GetWorkedDays().ToString();
    }
}

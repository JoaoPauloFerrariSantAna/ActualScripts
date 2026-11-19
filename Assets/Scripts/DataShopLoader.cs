using TMPro;
using UnityEngine;

public class DataShopLoader : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI currentMoney;

    [SerializeField]
    private TextMeshProUGUI currentDay;

    void Start()
    {
        this.currentMoney.text = DataTransferer.gInstance.GetPlayerMoney().ToString();
        this.currentDay.text = DataTransferer.gInstance.GetCurrentDay().ToString();
    }
}

using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class SellHouseBehaviour : MonoBehaviour
{
    private Button sellButton;

    void Start()
    {
        this.sellButton = this.GetComponent<Button>();
        this.sellButton.interactable = false;
    }

    void Update()
    {
        if(GameManager.gInstance.mHouse.IsHouseSellable())
        {
            this.sellButton.interactable = true;
            return;
        }
    }

    public void SellHouse()
    {
        GameManager.gInstance.UpdateAmountOfHousesSold();
        GameManager.gInstance.mPlayer.SellHouse(GameManager.gInstance.mHouse.CurrentPrice);
        GameManager.gInstance.mHouse.Sell();
        this.sellButton.interactable = false;
    }
}

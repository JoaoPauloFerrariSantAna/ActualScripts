using UnityEngine;
using UnityEngine.UI;

public class FurnishHouseUpgrade : MonoBehaviour
{
    private Image buttonImage;
    private Button button;

    private void Start()
    {
        this.button = this.GetComponent<Button>();
        this.buttonImage = this.GetComponent<Image>();
    }

    public void Update()
    {
        if (GameManager.gInstance.mPlayer.GetMoney() >= GameManager.gInstance.mHouse.CurrentPrice)
        {
            this.button.interactable = true;
            return;
        }

        this.button.interactable = false;
    }

    public void FurnishIt()
    {
        GameManager.gInstance.mPlayer.UpdateMoney(GameManager.gInstance.mHouse.CurrentPrice * (-1));
        GameManager.gInstance.mHouse.UpdatePrice();
        GameManager.gInstance.mHouse.NotifyFurnishing();
    }
}

using UnityEngine;
using UnityEngine.UI;

public class FurnishHouseUpgrade : MonoBehaviour
{
    private Button button;

    private void Start()
    {
        this.button = this.GetComponent<Button>();
    }

    public void ReactToOnEnter()
    {
        if (GameManager.gInstance.mPlayer.GetMoney() >= GameManager.gInstance.PriceToFurnishHouse)
        {
            this.button.interactable = true;
            return;
        }

        this.button.interactable = false;
    }

    public void FurnishIt()
    {
        GameManager.gInstance.mPlayer.UpdateMoney(GameManager.gInstance.PriceToFurnishHouse * (-1));
        GameManager.gInstance.UpdatePriceToFurnishIt();
        DataTransferer.gInstance.SetPlayerMoney(GameManager.gInstance.mPlayer.GetMoney());
    }
}

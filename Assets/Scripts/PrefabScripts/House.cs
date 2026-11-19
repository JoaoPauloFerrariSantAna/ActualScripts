using UnityEngine;

public class House : MonoBehaviour
{
    private int TimesFurnished = 0;
    private bool IsSellable;
    public float CurrentPrice = Constants.InitialPriceToFurnish;

    public void Start()
    {
        this.IsSellable = false;
    }
    
    public void NotifyFurnishing()
    {
        TimesFurnished++;

        if (TimesFurnished >= Constants.MinimalTimesToFurnishHouseToSell)
        {
            IsSellable = true;
        }
    }

    public void UpdatePrice()
    {
        this.CurrentPrice += (this.CurrentPrice * Constants.FurnishPriceMultiplier);
    }

    public bool IsHouseSellable()
    {
        return IsSellable;
    }

    public void Sell()
    {
        TimesFurnished = 0;
        this.CurrentPrice = InitialValues.InitialPriceToFurnish;
    }
}
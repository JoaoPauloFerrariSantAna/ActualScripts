using UnityEngine;

public class House : MonoBehaviour
{
    private static int TimesFurnished = 0;

    private bool IsSellable = false;
    
    public float CurrentPrice { get; private set; } = InitialValues.InitialPriceToFurnish;

    public void NotifyFurnishing()
    {
        TimesFurnished++;

        if (TimesFurnished >= InitialValues.MinimalTimesToFurnishHouseToSell)
        {
            this.IsSellable = true;
        }
    }

    public void UpdatePrice()
    {
        this.CurrentPrice += (this.CurrentPrice * InitialValues.FurnishPriceMultiplier);
    }

    public bool IsHouseSellable()
    {
        return this.IsSellable;
    }

    public void Sell()
    {
        TimesFurnished = 0;
        this.CurrentPrice = InitialValues.InitialPriceToFurnish;
    }
}
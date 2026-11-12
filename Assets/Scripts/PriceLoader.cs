using System;
using TMPro;
using UnityEngine;

public class PriceLoader : MonoBehaviour
{

    public TextMeshProUGUI whereToLoadThePrice;

    // because we're going to modify the price
    private void Update()
    {
        this.whereToLoadThePrice.text = Math.Round(GameManager.gInstance.mHouse.CurrentPrice, 2).ToString();
    }
}

using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private float Money = Constants.InitialPlayerMoney;
    [SerializeField]
    private float BankAccount = Constants.InitialMoneyInAccount;

    public float GetMoney()
    {
        return this.Money;
    }

    public void UpdateMoney(float amount)
    {
        this.Money += amount;
    }

    public float GetBankAccount()
    {
        return this.BankAccount;
    }

    public void SellHouse(float housePrice)
    {
        this.BankAccount += housePrice;
    }
}

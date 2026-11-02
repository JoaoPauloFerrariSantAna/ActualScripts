using UnityEngine;

public class Player : MonoBehaviour
{
    private float Money = InitialValues.InitialPlayerMoney;
    private float BankAccount = InitialValues.InitialMoneyInAccount;

    public float GetMoney()
    {
        return this.Money;
    }

    public void UpdateMoney(float amount)
    {
        this.Money += amount;
    }
}

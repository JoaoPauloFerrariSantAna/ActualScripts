using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private float Money = InitialValues.InitialPlayerMoney;
    [SerializeField]
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

using UnityEngine;

public class PlayerBalance : MonoBehaviour
{
    public int maxBalance = 50;
    public int currentBalance;

    public BalanceBar balanceBar;

    void Start()
    {
        currentBalance = maxBalance / 2;
        balanceBar.SetMaxBalance(maxBalance);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
            UnFocus(5);
        if (Input.GetKeyDown(KeyCode.G))
            Focus(5);
    }

    void UnFocus(int balance)
    {
        currentBalance -= balance;
        balanceBar.SetBalance(currentBalance);
    }

    void Focus(int balance)
    {
        currentBalance += balance;
        balanceBar.SetBalance(currentBalance);
    }
}

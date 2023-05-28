using UnityEngine;

public class PlayerBalance : MonoBehaviour
{
    public float maxBalance = 100f;
    public float currentBalance;

    public BalanceBar balanceBar;

    private float positif_or_neg = 0.15f;

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
        if (currentBalance >= maxBalance) {
            positif_or_neg = -0.15f;
        } else if (currentBalance <= 0) {
            positif_or_neg = 0.15f;
        }
        if (PauseManager.instance.gameIsPaused == false)
            Focus(positif_or_neg);
    }

    void UnFocus(float balance)
    {
        currentBalance -= balance;
        balanceBar.SetBalance(currentBalance);
    }

    void Focus(float balance)
    {
        currentBalance += balance;
        balanceBar.SetBalance(currentBalance);
    }
}

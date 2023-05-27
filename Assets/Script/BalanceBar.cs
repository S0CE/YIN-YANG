using UnityEngine;
using UnityEngine.UI;

public class BalanceBar : MonoBehaviour
{
    public Slider slider;

    public void SetMaxBalance(int balance)
    {
        slider.maxValue = balance;
        slider.value = balance / 2;
    }

    public void SetBalance(int balance)
    {
        slider.value = balance;
    }
}

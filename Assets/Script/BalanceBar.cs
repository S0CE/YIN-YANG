using UnityEngine;
using UnityEngine.UI;

public class BalanceBar : MonoBehaviour
{
    public Slider slider;

    public void SetMaxBalance(float balance)
    {
        slider.maxValue = balance;
        slider.value = balance / 2;
    }

    public void SetBalance(float balance)
    {
        slider.value = balance;
    }
}

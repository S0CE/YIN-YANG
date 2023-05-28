using UnityEngine;
using UnityEngine.UI;

public class ChangeWorld : MonoBehaviour
{
    public Image ChangeColor;
    public Slider slider;
    public PlayerHealth playerHealth;

    void Update()
    {
        DisplayImage();
    }
    
    void DisplayImage()
    {
        int health = playerHealth.health;
        if (slider.value == slider.maxValue)
            ChangeColor.enabled = true;
        else if (slider.value == 0)
            ChangeColor.enabled = false;


        if (Input.GetKeyDown(KeyCode.P))
            ChangeColor.enabled = !ChangeColor.enabled;
            
        if (health <= 0)
            ChangeColor.enabled = false;
    }
}

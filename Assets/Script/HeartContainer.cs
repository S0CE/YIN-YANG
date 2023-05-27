using UnityEngine;
using UnityEngine.UI;

public class HeartContainer : MonoBehaviour
{
    public Image[] hearts;

    public Sprite full;
    public Sprite empty;

    public void UpdateHealth(int health)
    {
        foreach (Image img in hearts)
        {
            img.sprite = empty;
        }
        for (int i = 0; i < health; i++)
        {
            hearts[i].sprite = full;
            
        }
    }
}

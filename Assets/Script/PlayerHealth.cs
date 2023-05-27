using UnityEngine;
using System.Collections;

public class PlayerHealth : MonoBehaviour
{
    public int health;

    public float InvTimeHit = 3f;
    public float InvFlashDelay = 0.3f;
    public bool isInvincible = false;

    public SpriteRenderer graphics;
    public HeartContainer heartContainer;

    void Start()
    {
        health = 3;
    }

    void Update()
    {
        heartContainer.UpdateHealth(health);
    }

    public void TakeDamage(int damage)
    {
        if (!isInvincible) {
            health -= damage;
            isInvincible = true;
            StartCoroutine(InvincibleFlash());
            StartCoroutine(InvincibleDelay());
        }

    }

    public IEnumerator InvincibleFlash()
    {
        while (isInvincible)
        {
            graphics.color = new Color(1f, 1f, 1f, 0f);
            yield return new WaitForSeconds(InvFlashDelay);
            graphics.color = new Color(1f, 1f, 1f, 1f);
            yield return new WaitForSeconds(InvFlashDelay);
        }
    }

    public IEnumerator InvincibleDelay()
    {
        yield return new WaitForSeconds(InvTimeHit);
        isInvincible = false;
    }
}

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

    public static PlayerHealth instance;

    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("Plus d'une instance PlayerHealth");
            return;
        }

		instance = this;
    }

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

            if (health <= 0) {
                Die();
                return;
            }

            isInvincible = true;
            StartCoroutine(InvincibleFlash());
            StartCoroutine(InvincibleDelay());
        }

    }

    public void Die()
    {
        PlayerMovement.instance.enabled = false;
        PlayerMovement.instance.animator.SetTrigger("Die");
        PlayerMovement.instance.rb.bodyType = RigidbodyType2D.Kinematic;
        PlayerMovement.instance.playerCollision.enabled = false;
        PlayerMovement.instance.rb.velocity = Vector3.zero;
        GameOverManager.instance.OnPlayerDeath();
    }

    public void Respawn()
    {
        PlayerMovement.instance.enabled = true;
        PlayerMovement.instance.animator.SetTrigger("Respawn");
        PlayerMovement.instance.rb.bodyType = RigidbodyType2D.Dynamic;
        PlayerMovement.instance.playerCollision.enabled = true;
        GameOverManager.instance.OnPlayerDeath();
        health = 3;
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

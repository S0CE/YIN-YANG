using UnityEngine;

public class DeathZone : MonoBehaviour
{
    public int damageOnCollsion = 3;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            collision.transform.position = GameObject.FindGameObjectWithTag("RespawnPoint").transform.position;
            PlayerHealth.instance.isInvincible = false;
            PlayerHealth.instance.TakeDamage(damageOnCollsion);
        }
    }
}

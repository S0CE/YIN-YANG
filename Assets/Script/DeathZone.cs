using UnityEngine;

public class DeathZone : MonoBehaviour
{
    public int damageOnCollsion = 1;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            collision.transform.position = GameObject.FindGameObjectWithTag("RespawnPoint").transform.position;
            PlayerHealth playerHealth = collision.transform.GetComponent<PlayerHealth>();
            playerHealth.TakeDamage(damageOnCollsion);
        }
    }
}

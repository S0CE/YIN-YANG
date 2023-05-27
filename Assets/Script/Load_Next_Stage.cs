using UnityEngine;
using UnityEngine.SceneManagement;

public class Load_Next_Stage : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")) {
            SceneManager.LoadScene("model 4");
        }
    }
}

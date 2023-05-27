using UnityEngine;
using UnityEngine.SceneManagement;

public class Load_Next_Stage : MonoBehaviour
{
    public string sceneName;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")) {
            SceneManager.LoadScene(sceneName);
        }
    }
}

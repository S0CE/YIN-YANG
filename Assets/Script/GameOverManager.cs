using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour
{
    public GameObject gameOverUI;

    public string sceneName;

    public static GameOverManager instance;

    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("Plus d'une instance GameOverManager");
            return;
        }

		instance = this;
    }

    public void OnPlayerDeath()
    {
        if (CurrentSceneManager.instance.isPlayerByDefault) {
            DontDestroy.instance.RemoveFromDestroy();
        }

        gameOverUI.SetActive(true);
    }

    public void RetryButton()
    {
        SceneManager.LoadScene(sceneName);
        gameOverUI.SetActive(false);
    }

    public void MainButton()
    {
        SceneManager.LoadScene("Main Menu");
        gameOverUI.SetActive(false);
    }

    public void QuitButton()
    {
        Application.Quit();
    }
}

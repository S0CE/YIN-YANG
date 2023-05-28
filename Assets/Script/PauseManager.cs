using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseManager : MonoBehaviour
{
    public bool gameIsPaused = false;

    public GameObject pauseBouton;
    public GameObject pauseUI;

    public static PauseManager instance;

    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("Plus d'une instance PauseManager");
            return;
        }

		instance = this;
    }

    public void PauseGoToMenu()
    {
        if (CurrentSceneManager.instance.isPlayerByDefault) {
            DontDestroy.instance.RemoveFromDestroy();
        }

        SceneManager.LoadScene("Main Menu");
        PauseManager.instance.Resumed();
    }

    public void Paused()
    {
        pauseBouton.SetActive(false);
        pauseUI.SetActive(true);
        Time.timeScale = 0;
        gameIsPaused = true;
    }

    public void Resumed()
    {
        pauseBouton.SetActive(true);
        pauseUI.SetActive(false);
        Time.timeScale = 1;
        gameIsPaused = false;
    }
}

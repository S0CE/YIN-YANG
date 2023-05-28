using UnityEngine;
using UnityEngine.SceneManagement;

public class Main_menu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Level 01");
    }
    
    public void QuitGame()
    {
        Application.Quit();
    }
}
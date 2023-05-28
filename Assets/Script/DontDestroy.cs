using UnityEngine;
using UnityEngine.SceneManagement;

public class DontDestroy : MonoBehaviour
{
    public GameObject[] objects;

    public static DontDestroy instance;

    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("Plus d'une instance DontDestroy");
            return;
        }

		instance = this;

        foreach (var element in objects)
        {
            DontDestroyOnLoad(element);
        } 
    }

    public void RemoveFromDestroy()
    {
        foreach (var element in objects)
        {
            SceneManager.MoveGameObjectToScene(element, SceneManager.GetActiveScene());
        }
    }
}

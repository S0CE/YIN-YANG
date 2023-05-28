using UnityEngine;

public class CurrentSceneManager : MonoBehaviour
{
    public bool isPlayerByDefault = false;

    public static CurrentSceneManager instance;

    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("Plus d'une instance CurrentSceneManager");
			return;
        }

		instance = this;
    }
}

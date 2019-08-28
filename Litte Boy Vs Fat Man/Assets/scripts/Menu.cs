using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void ShowMultiplayerMenu()
    {
        SceneManager.LoadScene(4);
    }
}

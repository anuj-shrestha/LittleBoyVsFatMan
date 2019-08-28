using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayMenu : MonoBehaviour
{
    public void StartExplore()
    {
        SceneManager.LoadScene(3);
    }

    public void StartUpgrades()
    {
        SceneManager.LoadScene(2);
    }

    public void GoBack()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    private void Update()
    {
        var moneyTxt = GameObject.Find("PlayerMoney").GetComponent<Text>();
        moneyTxt.text = "$: " + ((int)PlayerPrefs.GetFloat("PlayerMoney")).ToString();
    }

    public void ShowMultiplayerMenu()
    {
        SceneManager.LoadScene(4);
    }
}

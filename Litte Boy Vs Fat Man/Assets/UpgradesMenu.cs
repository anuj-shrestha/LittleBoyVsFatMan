using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UpgradesMenu : MonoBehaviour
{
    public float PlaneUpgradeCost = 1000f;

    private void Start()
    {
        PlaneUpgradeCost = PlayerPrefs.GetFloat("NextPlaneUpgradeCost", 1000);
    }

    public void UpgradePlane()
    {
        var playerMoney = PlayerPrefs.GetFloat("PlayerMoney");

        if (playerMoney >= PlaneUpgradeCost) {

            PlayerPrefs.SetInt("PlaneType", PlayerPrefs.GetInt("PlaneType", 0) + 1);
            playerMoney -= PlaneUpgradeCost;
            PlayerPrefs.SetFloat("PlayerMoney", playerMoney);
            PlaneUpgradeCost *= 10;
            PlayerPrefs.SetFloat("NextPlaneUpgradeCost", PlaneUpgradeCost);
        }
    }

    private void FixedUpdate()
    {
        var upgradePlaneTxt = GameObject.Find("UpgradePlane").GetComponent<Text>();
        upgradePlaneTxt.text = "Plane ($ " + ((int) PlaneUpgradeCost).ToString() + ")";

        var moneyTxt = GameObject.Find("PlayerMoney").GetComponent<Text>();
        moneyTxt.text = "$: " + ((int)PlayerPrefs.GetFloat("PlayerMoney")).ToString();
    }

    public void GoBack()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

}

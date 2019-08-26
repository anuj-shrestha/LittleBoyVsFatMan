using UnityEngine;
using UnityEngine.UI;

public class GetPlayerMoney : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var moneyTxt = GameObject.Find("PlayerMoney").GetComponent<Text>();
        moneyTxt.text = "$: " + ((int) PlayerPrefs.GetFloat("PlayerMoney")).ToString();
    }
}

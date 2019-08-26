using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject bg;
    public int bgPool = 3;
    List<GameObject> bgs;
    public GameObject gameOverUI;

    public static int enemiesDestroyed;

    public int EnemiesDestroyed { get => enemiesDestroyed; set => enemiesDestroyed = value; }
    public static float BulletSpeed { get => bulletSpeed; set => bulletSpeed = value; }
    public static float PlayerMoney { get => playerMoney; set => playerMoney = value; }

    private static float bulletSpeed;

    private static float playerMoney;

    void Start()
    {
        bgs = new List<GameObject>();

        for (int i = 0; i < bgPool; i++)
        {
            GameObject obj = (GameObject)Instantiate(bg);
            obj.SetActive(false);
            bgs.Add(obj);

        }

        spawnBg();
        bulletSpeed = 10f;
        EnemyMovement.enemySpeed = 2f;
        playerMoney = PlayerPrefs.GetFloat("PlayerMoney");
    }

    void spawnBg()
    {
        for (int i = 0; i < bgs.Count; i++)
        {
            //RectTransform rt = (RectTransform) bgs[i].transform;
            //float imgHeight = rt.rect.height;
            float imgHeight = bgs[i].GetComponent<SpriteRenderer>().sprite.bounds.size.x;  // this is gonna be our height
            bgs[i].transform.position = new Vector3(transform.position.x, imgHeight * i, transform.position.z);
            bgs[i].SetActive(true);
        }
    }

    public void EndGame()
    {
        gameOverUI.SetActive(true);
        PlayerPrefs.SetFloat("PlayerMoney", playerMoney);
    }

    private void FixedUpdate()
    {
        var moneyTxt = GameObject.Find("PlayerMoney").GetComponent<Text>();
        moneyTxt.text = "$: " + ((int) playerMoney).ToString();
    }

    public static void AddPlayerMoney(float sum)
    {
        playerMoney += sum;
    }
}

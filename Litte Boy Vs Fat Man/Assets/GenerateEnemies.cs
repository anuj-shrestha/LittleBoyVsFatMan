using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateEnemies : MonoBehaviour
{
    public float generateRate = 0.4f;
    public GameObject enemy;
    public int enemyPoolAmount = 8;
    List<GameObject> enemies;

    // Start is called before the first frame update
    void Start()
    {
        enemies = new List<GameObject>();

        for (int i = 0; i < enemyPoolAmount; i++)
        {
            GameObject obj = (GameObject)Instantiate(enemy);
            obj.SetActive(false);
            enemies.Add(obj);

        }
        InvokeRepeating("SpawnEnemies", generateRate, generateRate);
    }

    void SpawnEnemies()
    {
        for (int i = 0; i < enemies.Count; i++)
        {
            if (!enemies[i].activeInHierarchy)
            {
                enemies[i].transform.position = new Vector3(transform.position.x, 10, transform.position.z);
                //enemies[i].transform.rotation = transform.rotation;
                enemies[i].SetActive(true);
                break;
            }
        }
    }
}

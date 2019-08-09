using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateEnemies : MonoBehaviour
{
    public float generateRate = 2f;
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
        InvokeRepeating("SpawnEnemyInGroup", 0, generateRate);
    }

    void SpawnEnemyInGroup()
    {
        int PatternNo = Random.Range(0, 9);
        EnemyPattern pattern = GetEnemyPattern(PatternNo);

        for (int i = 0; i < enemies.Count; i++)
        {
            if (!enemies[i].activeInHierarchy)
            {
                enemies[i].transform.position = new Vector3(pattern.initPos.x, pattern.initPos.y + i, pattern.initPos.z);
                //enemies[i].transform.rotation = transform.rotation;
                enemies[i].SetActive(true);
            }
        }
    }

    EnemyPattern GetEnemyPattern(int ptNo)
    {
        EnemyPattern pattern;

        switch (ptNo)
        {
            case 0:
                {
                    pattern = new EnemyPattern { patternNo = ptNo, initPos = new Vector3(0, 10, -1), increment = new Vector3(0, 1, 0) };
                    break;
                }
            case 1:
                {
                    pattern = new EnemyPattern { patternNo = ptNo, initPos = new Vector3(1, 10, -1), increment = new Vector3(0, 1, 0) };
                    break;
                }
            case 2:
                {
                    pattern = new EnemyPattern { patternNo = ptNo, initPos = new Vector3(-1, 10, -1), increment = new Vector3(0, 1, 0) };
                    break;
                }
            case 3:
                {
                    pattern = new EnemyPattern { patternNo = ptNo, initPos = new Vector3(2, 10, -1), increment = new Vector3(0, 1, 0) };
                    break;
                }
            case 4:
                {
                    pattern = new EnemyPattern { patternNo = ptNo, initPos = new Vector3(-2, 10, -1), increment = new Vector3(0, 1, 0) };
                    break;
                }
            case 5:
                {
                    pattern = new EnemyPattern { patternNo = ptNo, initPos = new Vector3(3, 10, -1), increment = new Vector3(-0.3f, 1, 0) };
                    break;
                }
            case 6:
                {
                    pattern = new EnemyPattern { patternNo = ptNo, initPos = new Vector3(-3, 10, -1), increment = new Vector3(0.3f, 1, 0) };
                    break;
                }
            case 7:
                {
                    pattern = new EnemyPattern { patternNo = ptNo, initPos = new Vector3(4, 10, -1), increment = new Vector3(0, 1, 0) };
                    break;
                }
            case 8:
                {
                    pattern = new EnemyPattern { patternNo = ptNo, initPos = new Vector3(-4, 10, -1), increment = new Vector3(0, 1, 0) };
                    break;
                }
            default:
                {
                    pattern = new EnemyPattern { patternNo = ptNo, initPos = new Vector3(0, 10, -1), increment = new Vector3(0, 1, 0) };
                    break;
                }
        }
        return pattern;
    }
}

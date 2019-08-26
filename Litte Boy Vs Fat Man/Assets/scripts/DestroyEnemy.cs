using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEnemy : MonoBehaviour
{
    int health = 2;
    public GameObject powerUpPrefab;

    private void OnBecameInvisible()
    {
        Destroy();
    }

    private void Destroy()
    {
        health = 2;
        gameObject.SetActive(false);
    }

    private void OnDisable()
    {
        CancelInvoke();
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Player")
        {
            Destroy();
            GameManager.enemiesDestroyed++;

        }

        if (other.tag == "Bullet")
        {
            health--;

            if (health < 1)
            {
                Destroy();
                GameManager.enemiesDestroyed++;
                GameManager.AddPlayerMoney(50f);
            }
        }
    }

    private void FixedUpdate()
    {
        if (GameManager.enemiesDestroyed >= GenerateEnemies.enemyPoolAmount/2)
        {
            GameManager.enemiesDestroyed = 0;
            var newPowerUp = ScriptableObject.CreateInstance<PowerUp>();
            newPowerUp.PowerUpType = "faster-bullet";

            var prefab = Instantiate(powerUpPrefab);
            newPowerUp.PowerupPrefab = prefab;
            //Debug.Log("new pwrup at " + transform.position);
            prefab.transform.position = transform.position;
        }
    }
}

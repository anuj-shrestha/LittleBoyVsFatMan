using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPowerUp : MonoBehaviour
{
    private void OnBecameInvisible()
    {
        Destroy();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Destroy();
            GameManager.BulletSpeed += 1.2f;
            GenerateBullets.fireRate *= 0.9f;

            int badLuck = Random.Range(1, 3);
            if (badLuck >= 2) {
                GenerateEnemies.enemyPoolAmount += 1;
            }
            EnemyMovement.enemySpeed += 0.2f;
            GenerateEnemies.generateRate -= 0.3f;
        }
    }

    private void Destroy()
    {
        GameObject.Destroy(gameObject);
    }

    
}

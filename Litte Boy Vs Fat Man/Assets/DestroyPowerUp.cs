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
            GameManager.BulletSpeed += 1f;
            GenerateBullets.fireRate -= 0.05f;
            if (Random.Range(1,2) == 1) {
                GenerateEnemies.enemyPoolAmount += 1;
                EnemyMovement.enemySpeed += 0.2f;
            }
        }
    }

    private void Destroy()
    {
        GameObject.Destroy(gameObject);
    }

    
}

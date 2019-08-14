using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEnemy : MonoBehaviour
{
    int health = 2;

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
        }

        if (other.tag == "Bullet")
        {
            health--;

            if (health < 1)
            {
                Destroy();
            }
        }
    }
}

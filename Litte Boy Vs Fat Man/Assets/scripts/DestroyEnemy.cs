using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEnemy : MonoBehaviour
{
    int collisionCount = 0;
    private void OnEnable()
    {
        Invoke("Destroy", 5f);
    }

    private void Destroy()
    {
        collisionCount = 0;
        gameObject.SetActive(false);
    }

    private void OnDisable()
    {
        CancelInvoke();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collisionCount > 10)
        {
            Destroy();
        } else
        {
            collisionCount++;
        }
    }
}

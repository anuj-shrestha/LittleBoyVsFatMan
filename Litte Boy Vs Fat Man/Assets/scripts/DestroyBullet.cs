using UnityEngine;
using UnityEngine.Networking;

public class DestroyBullet : NetworkBehaviour
{
    private void OnBecameInvisible()
    {
        Destroy();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
        {
            Destroy();
        }
    }

    private void Destroy()
    {
        gameObject.SetActive(false);
    }

    private void OnDisable()
    {
        CancelInvoke();
    }
}

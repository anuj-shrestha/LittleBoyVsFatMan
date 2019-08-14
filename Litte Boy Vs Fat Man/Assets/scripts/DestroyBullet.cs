using UnityEngine;

public class DestroyBullet : MonoBehaviour
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

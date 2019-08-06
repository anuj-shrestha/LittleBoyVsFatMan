
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    public Transform bullet;
    public float bulletSpeed = 10f;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, bulletSpeed * Time.deltaTime, 0);
    }
}

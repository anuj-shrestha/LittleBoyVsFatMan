
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    public Transform bullet;

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Translate(0, GameManager.BulletSpeed * Time.fixedDeltaTime, 0);
    }
}

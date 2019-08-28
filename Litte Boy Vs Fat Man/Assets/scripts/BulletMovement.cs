
using UnityEngine;
using UnityEngine.Networking;

public class BulletMovement : NetworkBehaviour
{
    public Transform bullet;

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Translate(0, GameManager.BulletSpeed * Time.fixedDeltaTime, 0);
    }
}

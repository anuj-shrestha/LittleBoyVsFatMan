using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float enemySpeed = 2f;


    // Update is called once per frame
    void FixedUpdate()
    {
        //transform.position = new Vector3(player.position.x, Camera.main.pixelHeight, -1);
        transform.Translate(0, -enemySpeed * Time.deltaTime, 0);

    }
}

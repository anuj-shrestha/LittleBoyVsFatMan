using UnityEngine;
using UnityEngine.Networking;

public class PlayerMovement : NetworkBehaviour
{    

    private Camera cam;
    public Transform player;
    public Rigidbody rb;
    public float moveSpeed = 2000f;
    public float playerOffsetY = 2f;
    Vector3 point;
    Vector2 mousePos;

    void Start()
    {
        cam = Camera.main;
        Vector3 point = player.position;
        Vector2 mousePos = player.position;
        Debug.Log("player pos" + point);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 point = new Vector3();
        Vector2 mousePos = new Vector2();

        // Get the mouse position from Event.
        // Note that the y position from Event is inverted.
     
        mousePos.x = Input.mousePosition.x;
        mousePos.y = Input.mousePosition.y;

        point = cam.ScreenToWorldPoint(new Vector3(mousePos.x, mousePos.y, cam.nearClipPlane));
        //player.position = new Vector3(point.x, point.y, 1);
        Vector2 direction = (point - player.position).normalized;

        rb.velocity = new Vector3(direction.x * moveSpeed * Time.fixedDeltaTime, direction.y * moveSpeed * Time.deltaTime + playerOffsetY, 0);
    }
}

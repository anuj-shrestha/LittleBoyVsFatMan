using UnityEngine;

public class PlayerMovement : MonoBehaviour
{    

    private Camera cam;
    public Transform player;
    public Rigidbody rb;
    public float moveSpeed = 2000f;

    void Start()
    {
        cam = Camera.main;
    }

    //void OnGUI()
    //{
    //    Vector3 point = new Vector3();
    //    Event currentEvent = Event.current;
    //    Vector2 mousePos = new Vector2();

    //    // Get the mouse position from Event.
    //    // Note that the y position from Event is inverted.
    //    mousePos.x = currentEvent.mousePosition.x;
    //    mousePos.y = cam.pixelHeight - currentEvent.mousePosition.y;

    //    point = cam.ScreenToWorldPoint(new Vector3(mousePos.x, mousePos.y, cam.nearClipPlane));

    //    GUILayout.BeginArea(new Rect(20, 20, 250, 120));
    //    GUILayout.Label("Screen pixels: " + cam.pixelWidth + ":" + cam.pixelHeight);
    //    GUILayout.Label("Mouse position: " + mousePos);
    //    GUILayout.Label("World position: " + point.ToString("F3"));
    //    GUILayout.Label("Player positin: " + player.position);
    //    GUILayout.EndArea();
    //}

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

        rb.velocity = new Vector3(direction.x * moveSpeed * Time.deltaTime, direction.y * moveSpeed * Time.deltaTime, 0);
    }
}

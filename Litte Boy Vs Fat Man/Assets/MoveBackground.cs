using UnityEngine;
using System.Collections.Generic;

public class MoveBackground : MonoBehaviour
{
    public float BGMoveSpeed = 1f;
    SpriteRenderer m_SpriteRenderer;
    float imgHeight;
    private void Start()
    {
        imgHeight = GetComponent<SpriteRenderer>().sprite.bounds.size.x;  // this is gonna be our height

    }

    private void FixedUpdate()
    {
        transform.Translate(-BGMoveSpeed * Time.deltaTime, 0, 0);
        if (transform.position.y <= -imgHeight)
        {
            Reset();
        }
    }

    private void Reset()
    {
        transform.position = new Vector3 (transform.position.x, imgHeight * 2, transform.position.z);
    }


}

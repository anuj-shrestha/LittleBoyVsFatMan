using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerupMovement : MonoBehaviour
{
    public float powerUpFallSpeed = 0.5f;
    int direction = 1;
    float swingSpeedX = 0;
    float swingSpeedY = 0;
    float startTime = 0;
    float startTimeX = 0;
    float max = -0.5f;
    float min = 0.5f;
    float maxX = -1f;
    float minX = 1f;

    // Update is called once per frame
    void FixedUpdate()
    {


        swingSpeedX = Mathf.Lerp(minX, maxX, startTimeX);
        swingSpeedY = Mathf.Lerp(min, max, startTime);
        transform.Translate(swingSpeedX * Time.fixedDeltaTime, (swingSpeedY - powerUpFallSpeed) * Time.fixedDeltaTime, 0);
        //transform.Translate(0, powerUpFallSpeed * Time.fixedDeltaTime, 0);
        startTime += 0.5f * Time.fixedDeltaTime;
        startTimeX += 0.5f * Time.fixedDeltaTime;

        if (startTime > 1f)
        {
            var temp = max;
            max = min;
            min = temp;
            startTime = 0;
        }

        if (startTimeX > 2f)
        {
            var tempX = maxX;
            maxX = minX;
            minX = tempX;
            startTimeX = 0;
        }

    }
}

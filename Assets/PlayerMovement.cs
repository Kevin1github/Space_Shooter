using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{

    void Update()
    {
        var worldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition); // [cite: 589, 590]

        worldPoint.z = 0; // [cite: 591]

        transform.position = worldPoint; // [cite: 592]
    }
}
using UnityEngine;
using System.Collections;

public class ShowLog : MonoBehaviour
{
    void Start()
    {
        Debug.Log("Hello World!"); // [cite: 468]
    }

    void Update()
    {
        Debug.Log("Update called! " + Time.frameCount); // [cite: 473]
    }
}
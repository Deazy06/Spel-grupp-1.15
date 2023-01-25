using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGScroll : MonoBehaviour // Diyor. Gjorde s� att bakgrunden s�g ut som om att den var o�ndligt l�ng genom att duplicera bakgrunden och flytta tillbaka till startPos n�r bakgrunden har n�tt en viss punkt.
{
    public float speed = 4f;
    private Vector3 StartPosition;

    void Start()
    {
        StartPosition = transform.position;
    }


    void Update()
    {
        transform.Translate(Vector3.left*speed*Time.deltaTime);
        if (transform.position.x < -17.8801f)
        {
            transform.position = StartPosition;
        }
    }
}

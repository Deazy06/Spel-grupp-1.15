using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGScroll1 : MonoBehaviour
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
        if (transform.position.x > 17.8801f)
        {
            transform.position = StartPosition;
        }
    }
}

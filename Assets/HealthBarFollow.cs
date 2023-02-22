using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour // Script f�r att HealthBar ska f�lja efter playern Diyor
{
    private Vector3 offset = new Vector3(0f, 2.85f, 0f);
    public float smoothTime = 0.1f;
    private Vector3 velocity = Vector3.zero;
    [SerializeField] private Transform player;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        Vector3 pos = player.position + offset; ;
        transform.position = pos; 
        
        /*
        Vector3 targetPosition = player.position + offset;
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
        */
    }
}

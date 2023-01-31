using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class ControllFollowX : MonoBehaviour
{
    private Vector3 offset = new Vector3(-1f, 2.85f, 0f);
    public float smoothTime = 0.1f;
    private Vector3 velocity = Vector3.zero;
    [SerializeField] private Transform player;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        Vector3 pos = new Vector3(player.position.x, transform.position.y, transform.position.z);
        transform.position = pos ;

        /*
        Vector3 targetPosition = player.position + offset;
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
        */
    }
}

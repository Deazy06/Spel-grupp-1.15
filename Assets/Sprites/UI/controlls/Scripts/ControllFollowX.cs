using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class ControllFollowX : MonoBehaviour // OnScreenControlls följer player på X-axeln / Diyor
{
    private Vector3 offset = new Vector3(-1f, 2.85f, 0f);
    [SerializeField] private Transform player;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        Vector3 pos = new Vector3(player.position.x, transform.position.y, transform.position.z);
        transform.position = pos ;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileDelete : MonoBehaviour
{
    // Start is called before the first frame update

    public float life = 4.8f;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Destroy(this.gameObject, this.life);
    }
}
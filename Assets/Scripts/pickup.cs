using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickup : MonoBehaviour
{
    [SerializeField]
    private Text pickUpText;

    private bool pickUpAllowed;
    // Start is called before the first frame update
    void Start()
    {
        pickUpText.gameObject.setActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (pickUpAllowed && Input.GetKeyDown(KeyCode.E)) 
            PickUp();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("Player"))
        {
            pickUpText.gameObject.SetActive(true);
            pickUpAllowed = true;
        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name.Equals("Player"))
        {
            pickUpText.gameObject.SetActive(false);
            pickUpAllowed = false;
        }
    }
    private void PickUp()
    {
        Destroy(gameObject);
    }
}

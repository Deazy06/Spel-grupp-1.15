using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossLogic : MonoBehaviour
{
    bool start = false;
    [SerializeField] GameObject location;
    [SerializeField] GameObject player;
    [SerializeField] GameObject scrap;
    [SerializeField] int randomizer;
    Collider2D collide;
    float timer;
    // Start is called before the first frame update
    void Start()
    {
        collide = GetComponent<Collider2D>();
        location = GameObject.Find("BossLocation");
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.R))
        {
            Randomize();
        }
        if (start == true)
        {
            timer += 1 * Time.deltaTime;
            if (timer >= 3)
            {
                timer = 0;
                Randomize();
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        collide.enabled = false;
        start = true;
        Randomize();

    }  
    private void Restart()
    {
        start = false;
        start = true;
    }

    private void Randomize()
    {
        randomizer = Random.Range(1, 4);
        if (randomizer == 1)
        {
            print("1");
        }
        else if (randomizer == 2)
        {
            print("2");
            player = GameObject.Find("Player");
            Instantiate(scrap, player.transform.position + new Vector3(0,10,0), transform.rotation);
        }
        else if (randomizer == 3)
        {
            print("3");
            for (int i = 0; i < 3; i++)
            {
                Instantiate(scrap, location.transform.position + new Vector3(Random.Range(-10, 10),0), transform.rotation);
            }
            
        }
    }
}

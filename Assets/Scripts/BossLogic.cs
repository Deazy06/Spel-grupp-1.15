using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossLogic : MonoBehaviour
{
    bool start = false;
    [SerializeField] GameObject attackLocation;
    [SerializeField] GameObject scrap;
    [SerializeField] int randomizer;
    Collider2D collide;
    float timer;
    // Start is called before the first frame update
    void Start()
    {
        collide = GetComponent<Collider2D>();
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
        }
        else if (randomizer == 3)
        {
            print("3");
            Instantiate(scrap, transform.position += new Vector3(10,10,Random.Range(-10,10)), transform.rotation);
        }
    }
}

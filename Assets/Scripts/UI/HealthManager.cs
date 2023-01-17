using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HealthManager : MonoBehaviour
{

    public Image healthBar;
    public float healthAmount = 100f;
    SpriteRenderer sprite;
    List<Color> colorchoose;
    Vector3 respawnPoint;


    // Start is called before the first frame update
    void Start()
    {
        respawnPoint = transform.position;

        sprite = GetComponent<SpriteRenderer>();
        GetComponent<Collider2D>();
        colorchoose = new List<Color>();
        colorchoose.Add(new Color(0, 0, 0, 1));
        colorchoose.Add(new Color(0, 0.5f, 0, 1));
        colorchoose.Add(new Color(0.5f, 1, 0.5f, 1));
        colorchoose.Add(new Color(1, 1, 1, 1));
    }

    // Update is called once per frame
    void Update()
    {
        if (healthAmount <= 0)
        {
            //Application.LoadLevel(Application.loadedLevel);
            GameObject.Find("Player").GetComponent<NewPlayerMovement>().enabled = false;
            if (Input.GetKeyDown(KeyCode.R))
            {
                PlayerRespawn();
                Heal(100);
                sprite.color = new Color(1, 1, 1, 1);
                
            }
        }
        
        /*
        if (Input.GetKeyDown(KeyCode.A)) //tar damage när man trycker ner den knappen (ska ändras till om man nuddar något)
        {
            TakeDamage(20);
        }

        if (Input.GetKeyDown(KeyCode.D)) // heakar när man trycker ner den knappen (ska ändras till om man äter/dricker något)
        {
            Heal(5);
        }
        */
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Danger")
        {
            TakeDamage(1);
            sprite.color = new Color(0, healthAmount / 100, 0, 1);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Danger")
        {
            TakeDamage(10);
            sprite.color = new Color(0, healthAmount / 100, 0, 1);
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Danger")
        {
            TakeDamage(1);
            sprite.color = new Color(0, healthAmount / 100, 0, 1);
        }
    }

    public void TakeDamage(float damage)
    {
        healthAmount -= damage;
        healthBar.fillAmount = healthAmount / 100f;
    }

    public void Heal(float healingAmount)
    {
        healthAmount += healingAmount;
        healthAmount = Mathf.Clamp(healthAmount, 0, 100);

        healthBar.fillAmount = healthAmount / 100f;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Respawn")
        {
            respawnPoint = transform.position;
            print("Set Spawnpoint");
        }
    }
    private void PlayerRespawn()
    {
        healthAmount = 100f;
        transform.position = new Vector3(0, 0, 0);
        transform.position = respawnPoint;
        GetComponent<NewPlayerMovement>().enabled = true;
        sprite.color = new Color(0,(100 - healthAmount)/100,0,1);
    }
}

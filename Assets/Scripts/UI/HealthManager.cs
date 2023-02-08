using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HealthManager : MonoBehaviour
{

    public Image healthBar;
    Collider2D collid;
    Rigidbody2D rg;
    public float healthAmount = 100f;
    SpriteRenderer sprite;
    Vector3 respawnPoint;
    public GameObject grave1;
    public GameObject grave2;

    //[SerializeField] private AudioSource deathsound;

    // Start is called before the first frame update
    void Start()
    {
        respawnPoint = transform.position;

        sprite = GetComponent<SpriteRenderer>();
        collid = GetComponent<Collider2D>();
        rg = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // När spelaren har 0 eller mindre liv: playermovement stängs av, sprite blir genomskinlig, grav sätts på och man kan trycka r för att starta om - Noel
        if (healthAmount <= 0) 
        {
            GameObject.Find("Player").GetComponent<NewPlayerMovement>().enabled = false;
            sprite.color = new Color(0, 0, 0, 0);
            grave1.SetActive(true);
            grave2.SetActive(true);
            //deathsound.Play();
          
            if (Input.GetKeyDown(KeyCode.R))
            {
                PlayerRespawn();
            }
        }
    }

    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Danger")
        {
            TakeDamage(10);
            sprite.color = new Color(healthAmount / 100, 0, 0, 1);
        }
        if (collision.gameObject.tag == "Food") // Få liv av macka + bli grön + förstör macka - Leon
        {
            Heal(10); 
            Destroy(collision.gameObject); 
            sprite.color = new Color(0.5f,1, 0.5f, 1);
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Danger") // ta skada av Danger + bli röd - Leon
        {
            TakeDamage(1);
            sprite.color = new Color(healthAmount / 100, 0,0, 1);
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
    private void OnTriggerEnter2D(Collider2D collision) // Vid collision med tag Respawn så sätts respawnpoint där spelaren står - Noel
    {
        if (collision.gameObject.tag == "Respawn")
        {
            respawnPoint = transform.position;
            print("Set Spawnpoint");
        }
        
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        sprite.color = new Color(1, 1, 1, 1);
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        sprite.color = new Color(1, 1, 1, 1);
    }
    private void PlayerRespawn() //Grav försvinner färgen återställs, livet återställs och spelaren teelporteras till respawnPoint - Noel
    {
        grave1.SetActive(false);
        grave2.SetActive(false);
        sprite.color = new Color(1, 1, 1, 1);
        healthAmount = 100f;
        Heal(100);
        transform.position = respawnPoint;
        GetComponent<NewPlayerMovement>().enabled = true;
    }
    
}

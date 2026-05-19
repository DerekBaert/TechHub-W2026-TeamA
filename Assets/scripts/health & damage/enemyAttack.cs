using UnityEngine;

public class enemyAttack : MonoBehaviour
{
    public GameObject player;
    public playerhealth health;
    private bool isInAttackZone = false;
    public int timeBetweenAttacks = 2;
    private float timeUntilAttack = 0;
    public int damage = 10;
 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = GameObject.Find("/Player");
        health = player.GetComponent<playerhealth>();
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        { isInAttackZone = true;
        health.TakeDamage(10); }
           
    
    }
    public void OnTriggerExit2D(Collider2D collision)
    {
        timeUntilAttack = 0;
        isInAttackZone = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (isInAttackZone)
        {
            timeUntilAttack += Time.deltaTime;
           
            if (timeUntilAttack > timeBetweenAttacks)
            {
                timeUntilAttack = 0;
                health.TakeDamage(damage);
            }
                     
        }

    }
}

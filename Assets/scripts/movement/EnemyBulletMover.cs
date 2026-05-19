using Unity.VisualScripting;
using UnityEngine;

public class EnemyBulletMover : MonoBehaviour
{
    public GameObject player;
    private Vector3 direction;
    public float speed = 5;
    public int damage = 5;
    public playerhealth health;
    private float time = 0f;
    public float duration = 10f;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            health = player.GetComponent<playerhealth>();
            health.TakeDamage(damage);
            Destroy(this.gameObject);
        }  
    }


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = FindFirstObjectByType<PlayerMovement>().gameObject;
        direction = player.transform.position - transform.position;
        direction = Vector3.Normalize(direction);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += direction * speed * Time.deltaTime;
        time += Time.deltaTime;
        if (time > duration)
        {
            Destroy(this.gameObject);
        }
    }
}

using UnityEngine;

public class enemyMovement : MonoBehaviour
{
    
    public GameObject player;
   public bool followPlayer = true;
    Vector2 mover;
    private Rigidbody2D rb2D;
    public int speed = 15;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //this finds the player object so we can use its information
        player = GameObject.Find("/Player");
        rb2D = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (followPlayer)
        {
            //this figures out what direction to send the object which this is attached to
            mover = player.transform.position - transform.position;
            mover = Vector2.Normalize(mover);
            //this tells the object this is attached to head that way
            rb2D.AddForce(mover * speed);
        }
    }
}

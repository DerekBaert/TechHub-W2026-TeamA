using UnityEngine;

public class enemyMovement : MonoBehaviour
{
    
    public GameObject player;
   public bool followPlayer = true;
    Vector2 mover;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = GameObject.Find("/Player");
    
}

    // Update is called once per frame
    void Update()
    {
        if (followPlayer)
        {
            //this figures out what direction to send the object which this is attached to
            mover = player.transform.position - transform.position;
            //this tells the object this is attached to head that way
            transform.Translate(mover * Time.deltaTime);
        }
    }
}

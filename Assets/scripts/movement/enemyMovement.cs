using UnityEngine;

public class enemyMovement : MonoBehaviour
{
    
    public GameObject player;
   public bool followPlayer = true;
    Vector2 mover;
    public int MaxSpeed = 10;
    public int MinSpeed = 5;
    public bool stopping = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //this finds the player object so we can use its information
        player = GameObject.Find("/Player");
    
}

    // Update is called once per frame
    void Update()
    {
        if (followPlayer)
        {
            //this figures out what direction to send the object which this is attached to
            mover = player.transform.position - transform.position;

            Debug.Log(mover);
            //this makes it so the enemy doesnt move to fast or to slow
            if (mover.x > MaxSpeed)
            {
                mover.x = MaxSpeed;
            }
            else if (mover.x < MinSpeed && mover.x >= 1.5f)
            {
                mover.x = MinSpeed;
            }
            else if (mover.x < -MaxSpeed)
            {
                mover.x = -MaxSpeed;
            }
            else if (mover.x > -MinSpeed && mover.x <= -1.5f)
            {
                mover.x = -MinSpeed;
            }
            if (mover.x > -1.5f && mover.x < 1.5f)
            {
                mover.x = 0;
            }

            if (mover.y > MaxSpeed)
            {
                mover.y = MaxSpeed;
            }
            else if (mover.y < MinSpeed && mover.y >= 1.5f)
            {
                mover.y = MinSpeed;
            }
            else if (mover.y < -MaxSpeed)
            {
                mover.y = -MaxSpeed;
            }
            else if (mover.y > -MinSpeed && mover.y <= -1.5f)
            {
                mover.y = -MinSpeed;
            }

            if (stopping)
            {
                if (mover.y > -1.5f && mover.y < 1.5f)
                {
                    mover.y = 0;
                }
                if (mover.x > -1.5f && mover.x < 1.5f)
                {
                    mover.x = 0;
                }
            }
            //this tells the object this is attached to head that way

            transform.Translate(mover * Time.deltaTime);
        }
    }
}

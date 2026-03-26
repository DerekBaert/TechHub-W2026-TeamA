using UnityEngine;

public class enemyMovement : MonoBehaviour
{
    
    public GameObject player;
   public bool followPlayer = true;
    public Vector2 mover; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (followPlayer)
        {
            transform.Translate(mover * Time.deltaTime);
        }
    }
}

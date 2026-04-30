using UnityEngine;

public class FlipToPlayer : MonoBehaviour
{
    public Transform player; // Drag the Player object here in the Inspector
    private bool isFacingRight = false;

    void Update()
    {
        if (player != null)
        {
            // If player is to the right and we are facing left
            if (player.position.x > transform.position.x && !isFacingRight)
            {
                Flip();
            }
            // If player is to the left and we are facing right
            else if (player.position.x < transform.position.x && isFacingRight)
            {
                Flip();
            }
        }
    }

    void Flip()
    {
        isFacingRight = !isFacingRight;

        // Method 1: Local Scale Flip (Mirrors object)
        Vector3 currentScale = transform.localScale;
        currentScale.x *= -1;
        transform.localScale = currentScale;

        /* 
        Method 2: Rotation Flip (Alternatively)
        transform.Rotate(0, 180, 0); 
        */
    }
}
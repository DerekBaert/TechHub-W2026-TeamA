using UnityEngine;

public class Attack : MonoBehaviour
{
    public Collider2D circleCollider;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        circleCollider = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space) == true)
        {
            circleCollider.enabled = true;
     
        }
        else
        { 
            circleCollider.enabled = false;

        }

    }
}

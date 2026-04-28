using Unity.VisualScripting;
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
       
        if (Input.GetKeyDown(KeyCode.Space) == true) 
        {
            print("SpaceClicked");
            circleCollider.enabled = true;

        }
        else
        {
       
            circleCollider.enabled = false;

        }

    }
}

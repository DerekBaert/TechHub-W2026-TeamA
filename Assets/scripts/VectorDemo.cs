using UnityEngine;

public class VectorDemo : MonoBehaviour
{
    public GameObject otherObject;
    public float speed = 5;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //// Outputs the distance between two points as a single float value
        Debug.Log("Distance: " + Vector2.Distance(transform.position, otherObject.transform.position));

        ////Direction
        Vector2 direction = transform.position - otherObject.transform.position;
        Debug.Log("Direction: " + direction);

        // Normalized Vector
        Debug.Log("Normalized Direction: " + Vector2.Normalize(direction));
    }

    // Update is called once per frame
    void Update()
    {
        float step = Time.deltaTime * speed;
        transform.position = Vector2.MoveTowards(transform.position, otherObject.transform.position, step);
    }
}

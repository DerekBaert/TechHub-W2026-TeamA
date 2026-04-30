using UnityEngine;

public class ConstantRotation : MonoBehaviour
{
    // Adjust speed from the Unity Inspector
    public Vector3 rotationSpeed = new Vector3(0, 50, 0);

    void Update()
    {
        // Multiply by Time.deltaTime to keep rotation consistent (degrees per second)
        transform.Rotate(rotationSpeed * Time.deltaTime);
    }
}
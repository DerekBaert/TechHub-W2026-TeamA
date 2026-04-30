using UnityEngine;

public class KeepRotation : MonoBehaviour
{
    // The rotation you want the child to maintain
    private Quaternion frozenRotation;

    void Start()
    {
        // Store initial rotation, or set specific Euler angles (e.g., 0,0,0)
        frozenRotation = transform.rotation;
    }

    void LateUpdate()
    {
        // Force the rotation to stay the same every frame
        transform.rotation = frozenRotation;
    }
}
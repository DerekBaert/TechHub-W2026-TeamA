using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletLifetime : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        var destroyTime = 1; // This is the time in seconds
        StartCoroutine(DestroyAfterTime(destroyTime));
    }   

    IEnumerator DestroyAfterTime(float destroyTime)
    {
        yield return new WaitForSeconds(destroyTime);
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

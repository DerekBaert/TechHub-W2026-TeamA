using UnityEngine;
using System.Collections;


public class Spawnerlogic : MonoBehaviour
{
   private float xPosition;
    private float yPosition;
    private Vector3 spawnPosition;
    [SerializeField]
    private GameObject objectToSpawn;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        RandomSpawn();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void RandomSpawn()
    {
        xPosition = Random.Range(-45f, 45f);
        yPosition = Random.Range(-45f, 45f);
        spawnPosition = new Vector3(xPosition, yPosition, transform.position.z);
        Instantiate(objectToSpawn, spawnPosition, Quaternion.identity);
    }
}

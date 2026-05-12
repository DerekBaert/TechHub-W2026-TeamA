using UnityEngine;
using System.Collections;
using System.Runtime.CompilerServices;


public class Spawnerlogic : MonoBehaviour
{
   private float xPosition;
    private float yPosition;
    private Vector3 spawnPosition;
    [SerializeField]
    private GameObject objectToSpawn;
   public float spawnInterval = 1.5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("RandomSpawn", 2f, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
       

        
    }

    void RandomSpawn()
    {
        xPosition = Random.Range(-45f, 45f);
        yPosition = Random.Range(-45f, 45f);
        spawnPosition = new Vector3(xPosition, yPosition, 0);
        Instantiate(objectToSpawn, spawnPosition, Quaternion.identity);
   
    }
}

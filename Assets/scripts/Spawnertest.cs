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
    public float startAfter = 2f;
    public int spawnAmount = 5;
    private int amountSpawned = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("RandomSpawn", startAfter, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
       

        
    }

    void RandomSpawn()
    {
        if (amountSpawned < spawnAmount)
        {
            amountSpawned++;
            xPosition = Random.Range(-45f, 45f);
            yPosition = Random.Range(-45f, 45f);
            spawnPosition = new Vector3(xPosition, yPosition, 0);
            Instantiate(objectToSpawn, spawnPosition, Quaternion.identity);
        }
   
    }
}

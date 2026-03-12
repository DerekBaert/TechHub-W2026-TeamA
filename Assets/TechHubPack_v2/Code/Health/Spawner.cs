using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using Unity.Hierarchy;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UIElements;

// March 12 2026 (1:08 PM), I hate coding, it hurts my brain - Brayden (Tech Hub Team A Winter 2026)
/// <summary>
/// A class that spawns objects into the Scene at the transform of the object with the Spawner class.
/// </summary>
public class Spawner : MonoBehaviour
{
    [Header("Spawner Settings")]
    [SerializeField] private bool spawnOnStart = true;
    [SerializeField] private GameObject objectToSpawn;
    [SerializeField] protected GameObject latestSpawnedObject;
    public float spawnTime = 1f;
    public const float interval = 5.0f;

    [Header("Events")]
    public UnityEvent OnSpawn = new UnityEvent();
    
    [Header("Settings")]
    [SerializeField] private bool DEBUG_MODE;

    // Start is called before the first frame update.
    private void Start()
    {
        // If the object is to spawn on start of the game, spawn an object into the scene.
        if (spawnOnStart) SpawnObject();
    }
    void Update()
    {
        spawnTime += Time.deltaTime;

        if (spawnTime >= interval)
        {
            spawnTime -= interval;

            SpawnObject();
            //Randomize the spawn time and location of the enemy - Brayden
            //Plug the randomized number into the spawn time - Brayden
        }
    }
    // A function to...
    // Check time
    // and then spawn objects when time hits a certain amount

    /// <summary>
    /// Spawn an Object into the Scene at the position & rotation of the Spawner.
    /// </summary>
    public virtual void SpawnObject()
    {
        // Checks to see if there is a reference to a preFab, if not return an error.
        if (objectToSpawn == null)
        {
            Debug.LogError("There is no reference to a preFab.");
            return;
        }

        
        // Sets a reference from the instantiated object.
        latestSpawnedObject = Instantiate(objectToSpawn, transform.position, Quaternion.identity);
        
        
        // Calls OnSpawn Event while Object has spawned.
        OnSpawn.Invoke();
        
        
        if (DEBUG_MODE) Debug.Log("Spawned : " + latestSpawnedObject.name);
    }
}
    



using UnityEngine;

public class ActivateSpawner : MonoBehaviour
{
    public DeathCounter1 counterScript;
    private Spawnerlogic spawnerComponent;
    public int amountofDeaths = 5;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        counterScript = FindFirstObjectByType<DeathCounter1>();
        spawnerComponent = GetComponent<Spawnerlogic>();
        spawnerComponent.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (counterScript._counter >= amountofDeaths)
        {
            spawnerComponent.enabled = true;
        }
    }
}

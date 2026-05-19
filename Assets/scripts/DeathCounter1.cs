using UnityEngine;

public class DeathCounter1 : MonoBehaviour
{
    public EnemysLeftUI enemyUI;
    public int _counter = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        enemyUI = FindFirstObjectByType<EnemysLeftUI>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void IncreaseCounter()
    {
        _counter = _counter + 1;
        enemyUI.UpdateText();
    }

}

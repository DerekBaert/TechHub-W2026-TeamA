using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class EnemysLeftUI : MonoBehaviour
{
    public DeathCounter1 deathCounter;
    public int deathAmount = 5;
    public TMP_Text text;
    public string enemysLeft = "Enemys Left: ";
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        deathCounter = FindFirstObjectByType<DeathCounter1>();
        text = GetComponent<TMP_Text>();
        enemysLeft = enemysLeft + (deathAmount - deathCounter._counter);
        text.SetText(enemysLeft);
    }

    // Update is called once per frame
    void Update()
    {  
    }

    public void UpdateText() 
    {
        enemysLeft = null;
        enemysLeft = enemysLeft + (deathAmount - deathCounter._counter);
        text.SetText(enemysLeft);
    }
}

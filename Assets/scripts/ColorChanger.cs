using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    public SpriteRenderer spriteRender;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spriteRender = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeColorRed() 
    {
        spriteRender.color = new Color(255, 0, 0, 225);
    }

    public void ResetColor() 
    {
        spriteRender.color = new Color(255, 255, 255, 255);
    }
}

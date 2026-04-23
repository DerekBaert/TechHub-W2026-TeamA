using JetBrains.Annotations;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    public SpriteRenderer spriteRender;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private Color originalColor;
    void Start()
    {
        spriteRender = GetComponent<SpriteRenderer>();
        originalColor = spriteRender.color;
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
        spriteRender.color = originalColor;
    }
}

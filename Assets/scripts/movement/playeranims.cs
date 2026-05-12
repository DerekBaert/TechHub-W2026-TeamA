using Unity.VisualScripting;
using UnityEngine;

public class Animcontroller : MonoBehaviour
{
    private Animator animator;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            animator.SetBool("MoveUp", true);
            animator.SetBool("MoveLeft", false);
            animator.SetBool("MoveRight", false);
            animator.SetBool("Idle", false);
            animator.SetBool("MoveDown", false);
        }

        if (Input.GetKey(KeyCode.S))
        {
            animator.SetBool("MoveUp", false);
            animator.SetBool("MoveLeft", false);
            animator.SetBool("MoveRight", false);
            animator.SetBool("MoveDown", true);
            animator.SetBool("Idle", false);
        }
        if (Input.GetKey(KeyCode.D))
        {
            animator.SetBool("MoveUp", false);
            animator.SetBool("MoveLeft", false);
            animator.SetBool("MoveDown", false);
            animator.SetBool("MoveRight", true);
            animator.SetBool("Idle", false);
        }
        if (Input.GetKey(KeyCode.A))
        {
            animator.SetBool("MoveLeft", true);
            animator.SetBool("MoveUp", false);
            animator.SetBool("MoveRight", false);
            animator.SetBool("MoveDown", false);
            animator.SetBool("Idle", false);

        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            animator.SetBool("MoveUp", false);
            animator.SetBool("MoveLeft", false);
            animator.SetBool("MoveRight", false);
            animator.SetBool("MoveDown", false);
            animator.SetBool("Idle", true);
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            animator.SetBool("MoveUp", false);
            animator.SetBool("MoveLeft", false);
            animator.SetBool("MoveRight", false);
            animator.SetBool("MoveDown", false);
            animator.SetBool("Idle", true);
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            animator.SetBool("MoveUp", false);
            animator.SetBool("MoveLeft", false);
            animator.SetBool("MoveRight", false);
            animator.SetBool("MoveDown", false);
            animator.SetBool("Idle", true);
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            animator.SetBool("MoveUp", false);
            animator.SetBool("MoveLeft", false);
            animator.SetBool("MoveRight", false);
            animator.SetBool("MoveDown", false);
            animator.SetBool("Idle", true);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            animator.SetBool("MoveUp", true);
            animator.SetBool("MoveLeft", false);
            animator.SetBool("MoveRight", false);
            animator.SetBool("Idle", false);
            animator.SetBool("MoveDown", false);
        }
        if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            animator.SetBool("MoveUp", false);
            animator.SetBool("MoveLeft", false);
            animator.SetBool("MoveRight", false);
            animator.SetBool("MoveDown", false);
            animator.SetBool("Idle", true);
        }
        if 
            (Input.GetKey(KeyCode.DownArrow))
        {
            animator.SetBool("MoveUp", false);
            animator.SetBool("MoveLeft", false);
            animator.SetBool("MoveRight", false);
            animator.SetBool("MoveDown", true);
            animator.SetBool("Idle", false);
        }
        if  (Input.GetKeyUp(KeyCode.DownArrow))
        {
            animator.SetBool("MoveUp", false);
            animator.SetBool("MoveLeft", false);
            animator.SetBool("MoveRight", false);
            animator.SetBool("MoveDown", false);
            animator.SetBool("Idle", true);
        }
            if (Input.GetKey(KeyCode.RightArrow))
            {
                animator.SetBool("MoveUp", false);
                animator.SetBool("MoveLeft", false);
                animator.SetBool("MoveDown", false);
                animator.SetBool("MoveRight", true);
                animator.SetBool("Idle", false);
        }
        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            animator.SetBool("MoveUp", false);
            animator.SetBool("MoveLeft", false);
            animator.SetBool("MoveRight", false);
            animator.SetBool("MoveDown", false);
            animator.SetBool("Idle", true);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            animator.SetBool("MoveLeft", true);
            animator.SetBool("MoveUp", false);
            animator.SetBool("MoveRight", false);
            animator.SetBool("MoveDown", false);
            animator.SetBool("Idle", false);
        }
        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            animator.SetBool("MoveUp", false);
            animator.SetBool("MoveLeft", false);
            animator.SetBool("MoveRight", false);
            animator.SetBool("MoveDown", false);
            animator.SetBool("Idle", true);
        }
        
    }
}
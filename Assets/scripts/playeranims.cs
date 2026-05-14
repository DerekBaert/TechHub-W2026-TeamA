using Unity.VisualScripting;
using UnityEngine;

public class playeranims : MonoBehaviour
{
    private Animator animator;
    [SerializeField] private AudioClip backgroundMusicClip;
    [SerializeField, Range(0f, 1f)] private float backgroundMusicVolume = 0.4f;
    private AudioSource backgroundMusicSource;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animator = GetComponent<Animator>();

        if (backgroundMusicClip == null)
        {
            backgroundMusicClip = Resources.Load<AudioClip>("trash can");
        }

        if (backgroundMusicClip != null)
        {
            backgroundMusicSource = gameObject.AddComponent<AudioSource>();
            backgroundMusicSource.clip = backgroundMusicClip;
            backgroundMusicSource.loop = true;
            backgroundMusicSource.playOnAwake = false;
            backgroundMusicSource.volume = backgroundMusicVolume;
            backgroundMusicSource.Play();
        }
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
    }
}
using UnityEngine;

public class takingDamage : MonoBehaviour
{
    [SerializeField] private AudioClip takingDamageClip;
    [SerializeField] private AudioSource audioSource;

    private void Awake()
    {
        if (audioSource == null)
        {
            audioSource = GetComponent<AudioSource>();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        TryPlayTakingDamageClip(other.gameObject);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        TryPlayTakingDamageClip(other.gameObject);
    }

    private void TryPlayTakingDamageClip(GameObject otherObject)
    {
        if (!otherObject.CompareTag("EnemyBullet") || takingDamageClip == null)
        {
            return;
        }

        if (audioSource != null)
        {
            audioSource.PlayOneShot(takingDamageClip);
        }
        else
        {
            AudioSource.PlayClipAtPoint(takingDamageClip, transform.position);
        }
    }
}

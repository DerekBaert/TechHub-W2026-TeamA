using UnityEngine;

public class canenemy : MonoBehaviour
{
	[SerializeField] private AudioClip canenemyclip;

	private void OnTriggerEnter2D(Collider2D other)
	{
		if (other.CompareTag("playerbullet") || other.name == "playerbullet")
		{
			if (canenemyclip != null)
			{
				AudioSource.PlayClipAtPoint(canenemyclip, transform.position);
			}

			Destroy(gameObject);
		}
	}
}

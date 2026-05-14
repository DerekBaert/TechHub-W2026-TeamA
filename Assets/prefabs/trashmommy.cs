using UnityEngine;

public class trashmommy : MonoBehaviour 
{
	[SerializeField] private AudioClip trashMommyClip;

	private AudioSource audioSource;

	private void Awake()
	{
		audioSource = GetComponent<AudioSource>();

		if (audioSource == null)
		{
			audioSource = gameObject.AddComponent<AudioSource>();
		}

		audioSource.clip = trashMommyClip;
		audioSource.loop = true;
		audioSource.playOnAwake = false;
	}

	private void OnEnable()
	{
		if (audioSource != null && trashMommyClip != null)
		{
			audioSource.clip = trashMommyClip;
			audioSource.Play();
		}
	}

	private void OnDisable()
	{
		if (audioSource != null)
		{
			audioSource.Stop();
		}
	}

	private void OnDestroy()
	{
		if (audioSource != null)
		{
			audioSource.Stop();
		}
	}
}

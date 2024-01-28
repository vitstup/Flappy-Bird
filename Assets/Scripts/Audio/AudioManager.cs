using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] private AudioSource[] audioSources;

    public bool muted { get; private set; }

	private void Awake()
	{
        if (PlayerPrefs.HasKey("IsAudioMuted")) muted = PlayerPrefs.GetInt("IsAudioMuted") == 1;

		UpdateAudioSources();
	}

	public void ChangeStatus()
    {
        muted = !muted;

		UpdateAudioSources();

		PlayerPrefs.SetInt("IsAudioMuted", muted ? 1 : 0);
    }

    private void UpdateAudioSources()
    {
		foreach (AudioSource source in audioSources)
		{
			source.mute = muted;
		}
	}
}
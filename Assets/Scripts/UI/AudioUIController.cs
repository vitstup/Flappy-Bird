using UnityEngine;
using UnityEngine.UI;
using Zenject;

public class AudioUIController : MonoBehaviour
{
    [Inject] private AudioManager audioManager;

    [SerializeField] private Canvas audioCanvas;

    [SerializeField] private Image audioBtnImg;

    [SerializeField] private Sprite audioOnSprite;
    [SerializeField] private Sprite audioOffSprite;

	private void Start()
	{
		ChangeAudioBtnImg();
	}

	public void ChangeAudioMode()
    {
        audioManager.ChangeStatus();

		ChangeAudioBtnImg();
	}

    private void ChangeAudioBtnImg()
    {
		audioBtnImg.sprite = audioManager.muted ? audioOnSprite : audioOffSprite;
	}

    public void OpenAudioUI()
    {
		audioCanvas.enabled = true;
	}

    public void CloseAudioUI()
    {
        audioCanvas.enabled = false;
    }
}
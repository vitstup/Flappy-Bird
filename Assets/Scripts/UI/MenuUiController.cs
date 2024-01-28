using UnityEngine;
using Zenject;

public class MenuUiController : MonoBehaviour
{
    [Inject] AudioUIController audioUIController;

    [SerializeField] private Canvas menuCanvas;

    public void OpenMenu()
    {
        menuCanvas.gameObject.SetActive(true);
    }

    public void CloseMenu()
    {
		menuCanvas.gameObject.SetActive(false);
		audioUIController.CloseAudioUI();
	}

    public void OpenAudioSettings()
    {
        audioUIController.OpenAudioUI();
	}
}
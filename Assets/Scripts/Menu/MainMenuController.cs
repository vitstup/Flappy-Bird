using UnityEngine;
using Zenject;

public class MainMenuController : MonoBehaviour
{
    [Inject] private AudioUIController audioUiController;

    public void OpenAudioUI()
    {
        audioUiController.OpenAudioUI();
    }
}
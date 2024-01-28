using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

public class LostUIController : MonoBehaviour
{
    [SerializeField] private Canvas lostCanvas;

    [SerializeField] private TextMeshProUGUI currentScore;
    [SerializeField] private TextMeshProUGUI bestScore;
    [SerializeField] private Image medalImg; // maybe set sprites here

    [Inject] ScoreManager scoreManager;

    public void OpenLostCanvas()
    {
        lostCanvas.gameObject.SetActive(true);

        currentScore.text = scoreManager.score.ToString();
		bestScore.text = scoreManager.lastKnownBestScore.ToString();
    }
}
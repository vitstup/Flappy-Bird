using TMPro;
using UnityEngine;
using Zenject;

[RequireComponent(typeof(TextMeshProUGUI))]
public class ScoreTextUI : MonoBehaviour
{
	[Inject] ScoreManager scoreManager;

	private TextMeshProUGUI text;

	private void Awake()
	{
		text = GetComponent<TextMeshProUGUI>();

		scoreManager.ScoreChangedEvent += ScoreChanged;
	}

	private void ScoreChanged(int score)
	{
		text.text = score.ToString();
	}
}
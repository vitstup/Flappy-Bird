using TMPro;
using UnityEngine;

[RequireComponent(typeof(TextMeshProUGUI))]
public class BestScoreText : MonoBehaviour
{
    private TextMeshProUGUI text;

	[SerializeField] private string suffix;

	private void Awake()
	{
		text = GetComponent<TextMeshProUGUI>();
	}

	private void Start()
	{
		DisplayText();
	}

	private void DisplayText()
	{
		int record = 0;
		if (PlayerPrefs.HasKey("Score")) record = PlayerPrefs.GetInt("Score");
		text.text = suffix + " " + record;
	}
}
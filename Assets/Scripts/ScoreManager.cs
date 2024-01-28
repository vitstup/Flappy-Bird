using System;
using UnityEngine;
using Zenject;

public class ScoreManager : MonoBehaviour
{
	[Inject] private GameStatesManager gameManager;

	public Action<int> ScoreChangedEvent;

	private int _score;

    public int score
	{
		get => _score;
		private set
		{
			_score = value;
			ScoreChangedEvent?.Invoke(score);
		}
	}

	public int lastKnownBestScore { get; private set; }

	private void Start()
	{
		Hole.PassedEvent += AddScore;

		score = 0;

		if (PlayerPrefs.HasKey("Score")) lastKnownBestScore = PlayerPrefs.GetInt("Score");
	}

	private void AddScore()
	{
		if (gameManager.currentState.GetType() == typeof(LostState)) return;

		score++;

		if (lastKnownBestScore < score)
		{
			lastKnownBestScore = score;
			PlayerPrefs.SetInt("Score", lastKnownBestScore);
		}
	}
}
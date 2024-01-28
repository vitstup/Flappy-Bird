using UnityEngine;

public class PlayingState : GameState
{
	public override void OnEntered()
	{
		Time.timeScale = 1;
	}

	public override bool CanControll() => true;
}
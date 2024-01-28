using UnityEngine;
using Zenject;

public class PausedState : GameState
{
	[Inject] private MenuUiController controller;

	public override void OnEntered()
	{
		Time.timeScale = 0;
		controller.OpenMenu();
	}

	public override void OnExited()
	{
		Time.timeScale = 1;
		controller.CloseMenu();
	}
}
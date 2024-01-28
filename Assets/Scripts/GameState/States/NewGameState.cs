using UnityEngine;
using Zenject;

public class NewGameState : GameState
{
	[Inject] private PipesSpawner pipesSpawner;

	[Inject] private PlayerAnimationController playerAnimController;

	public override void OnEntered()
	{
		pipesSpawner.SpawnStartPipes();
		Time.timeScale = 0;
	}

	public override void OnExited()
	{
		playerAnimController.StartFlying();
	}

	public override bool CanControll() => true;
}
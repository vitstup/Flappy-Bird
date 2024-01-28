using Zenject;

public class LostState : GameState
{
	[Inject] LostUIController controller;

	[Inject] PlayerAnimationController animController;

	public override void OnEntered()
	{
		animController.StopFlying();

		controller.OpenLostCanvas();
	}
}
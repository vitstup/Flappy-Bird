using UnityEngine;
using Zenject;

public class Controller : MonoBehaviour
{
    [Inject] private Bird bird;
	[Inject] private GameStatesManager gameManager;

	private void Update()
	{
		if (gameManager.currentState.CanControll())
		{
			if (Input.GetKeyDown(KeyCode.Space) || 
				(!Helpers.IsOverUI() && (Input.GetMouseButtonDown(0))
				))
			{
				if (gameManager.currentState.GetType() == typeof(NewGameState)) gameManager.ChangeState(typeof(PlayingState));
				bird.Jump();
			}
		}
	}
}
using UnityEngine;
using Zenject;

public class PauseController : MonoBehaviour
{
	[Inject] GameStatesManager gameManager;

	public void OpenMenu()
	{
		gameManager.ChangeState(typeof(PausedState));
	}

	public void CloseMenu() 
	{
		gameManager.ChangeState(typeof(PlayingState));
	}
}
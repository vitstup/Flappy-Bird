using UnityEngine;
using Zenject;

public class GameManagerInstaller : MonoInstaller
{
	[SerializeField] private GameStatesManager gameManager;

	public override void InstallBindings()
	{
		Container.Bind<GameStatesManager>().FromComponentInHierarchy(gameManager).AsSingle().NonLazy();
	}
}
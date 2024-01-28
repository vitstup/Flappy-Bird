using UnityEngine;
using Zenject;

public class BirdInstaller : MonoInstaller
{
	[SerializeField] private Bird player;

	public override void InstallBindings()
	{
		Container.Bind<Bird>().FromComponentInHierarchy(player).AsSingle().NonLazy();
	}
}
using UnityEngine;
using Zenject;

public class PlayerAnimationControllerInstaller : MonoInstaller
{
	[SerializeField] private PlayerAnimationController controller;

	public override void InstallBindings()
	{
		Container.Bind<PlayerAnimationController>().FromComponentInHierarchy(controller).AsSingle().NonLazy();
	}
}
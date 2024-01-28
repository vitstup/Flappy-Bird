using UnityEngine;
using Zenject;

public class MenuUiControllerInstaller : MonoInstaller
{
	[SerializeField] private MenuUiController controller;

	public override void InstallBindings()
	{
		Container.Bind<MenuUiController>().FromComponentInHierarchy(controller).AsSingle().NonLazy();
	}
}
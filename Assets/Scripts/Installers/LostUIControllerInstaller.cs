using UnityEngine;
using Zenject;

public class LostUIControllerInstaller : MonoInstaller<LostUIControllerInstaller>
{
    [SerializeField] private LostUIController controller;

    public override void InstallBindings()
    {
		Container.Bind<LostUIController>().FromComponentInHierarchy(controller).AsSingle().NonLazy();
	}
}
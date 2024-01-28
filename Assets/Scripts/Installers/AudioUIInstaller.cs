using UnityEngine;
using Zenject;

public class AudioUIInstaller : MonoInstaller
{
	[SerializeField] private AudioUIController controller;

	public override void InstallBindings()
	{
		Container.Bind<AudioUIController>().FromComponentInNewPrefab(controller).AsSingle().NonLazy();
	}
}
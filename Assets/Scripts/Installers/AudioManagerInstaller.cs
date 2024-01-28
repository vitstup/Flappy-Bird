using UnityEngine;
using Zenject;

public class AudioManagerInstaller : MonoInstaller
{
	[SerializeField] private AudioManager manager;

	public override void InstallBindings()
	{
		Container.Bind<AudioManager>().FromComponentInNewPrefab(manager).AsSingle().NonLazy();
	}
}
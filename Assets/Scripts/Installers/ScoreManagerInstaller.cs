using UnityEngine;
using Zenject;

public class ScoreManagerInstaller : MonoInstaller
{
    [SerializeField] private ScoreManager scoreManager;

    public override void InstallBindings()
    {
		Container.Bind<ScoreManager>().FromComponentInHierarchy(scoreManager).AsSingle().NonLazy();
	}
}
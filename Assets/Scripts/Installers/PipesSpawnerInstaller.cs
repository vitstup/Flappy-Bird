using UnityEngine;
using Zenject;

public class PipesSpawnerInstaller : MonoInstaller
{
    [SerializeField] private PipesSpawner pipesSpawner;

    public override void InstallBindings()
    {
        Container.Bind<PipesSpawner>().FromComponentInHierarchy(pipesSpawner).AsSingle().NonLazy();
    }
}
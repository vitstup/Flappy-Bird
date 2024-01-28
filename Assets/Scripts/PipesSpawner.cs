using UnityEngine;
using Zenject;

public class PipesSpawner : MonoBehaviour
{
	[Inject] private GameStatesManager gameStatesManager;

	[SerializeField] private Transform world;
	
    [SerializeField] private PipesBlock prefab;
    private PipesPool pool;

	[SerializeField] private int startPipesAmount;
	[SerializeField] private float startLocation;
	[SerializeField] private float horizontalDistance;

	private void Awake()
	{
		pool = new PipesPool(prefab, 8, true);

		Hole.PassedEvent += SpawnPipe;
	}

	private void SpawnPipe()
	{
		if (gameStatesManager.currentState.GetType() == typeof(LostState)) return;

		var elements = pool.GetBusyElements();

		float position = startLocation;

		if (elements != null && elements.Count >= 1)
		{
			foreach (var element in elements)
			{
				if (element.transform.localPosition.x > position) position = element.transform.localPosition.x;
			}
		}

		var newPipe = pool.GetElement();
		newPipe.transform.SetParent(world);
		newPipe.transform.localPosition = new Vector2(position + horizontalDistance, 0);
	}

	public void SpawnStartPipes()
	{
		for (int i = 0; i < startPipesAmount; i++)
		{
			SpawnPipe();
		}
	}
}
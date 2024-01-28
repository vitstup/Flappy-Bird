using UnityEngine;
using Zenject;

public class WorldMover : MonoBehaviour
{
	[Inject] GameStatesManager gameManager;

    [SerializeField] private float speed;

	private void Update()
	{
		if (gameManager.currentState.GetType() == typeof(LostState)) return;

		foreach (Transform child in transform)
		{
			var pos = child.localPosition;

			child.localPosition = new Vector2 (pos.x + Time.deltaTime * -speed, pos.y);
		}
	}
}
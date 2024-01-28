using UnityEngine;

public class PipesBlock : MonoBehaviour
{
    [SerializeField] private Transform topPipe;
    [SerializeField] private Transform bottomPipe;

	[SerializeField] private BoxCollider2D hole;
	[SerializeField] private float holeWidth;

	[SerializeField] private float minHoleSize;
	[SerializeField] private float maxHoleSize;

	[SerializeField] private float minHolePos;
	[SerializeField] private float maxHolePos;


	[SerializeField] private string destroyerTag;

	private void Start()
	{
		PlacePipes();
	}

	private void PlacePipes()
    {
		var holeSize = Random.Range(minHoleSize, maxHoleSize);
		var holePos = Random.Range(minHolePos, maxHolePos);

		hole.transform.localPosition = new Vector2(0, holePos);
		hole.size = new Vector2 (holeWidth, holeSize);

		Vector2 topPipePos = new Vector2(0, holeSize / 2 + holePos);
		topPipe.localPosition = topPipePos;

		Vector2 bottomPipePos = new Vector2(0, -holeSize / 2 + holePos);
		bottomPipe.localPosition = bottomPipePos;
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.tag == destroyerTag)
		{
			gameObject.SetActive(false);
		}
	}
}
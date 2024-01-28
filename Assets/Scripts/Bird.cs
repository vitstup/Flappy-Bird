using UnityEngine;
using Zenject;

[RequireComponent (typeof(Rigidbody2D))]
public class Bird : MonoBehaviour
{
    [SerializeField] private float jumpForce;
    [SerializeField] private string pipeTag;

	private Rigidbody2D rb;

	[Inject] private GameStatesManager gameManager;

	private void Awake()
	{
		rb = GetComponent<Rigidbody2D>();
	}

	public void Jump()
    {
		rb.AddForce(jumpForce * Vector2.up);
    }

	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.transform.tag == pipeTag)
		{
			gameManager.ChangeState(typeof(LostState));
		}
	}
}
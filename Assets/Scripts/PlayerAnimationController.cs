using UnityEngine;

[RequireComponent (typeof(Animator))]
public class PlayerAnimationController : MonoBehaviour
{
    private Animator animator;

	private void Awake()
	{
		animator = GetComponent<Animator>();
	}

	public void StartFlying()
    {
        animator.SetBool("IsFlying", true);
    }

    public void StopFlying()
    {
		animator.SetBool("IsFlying", false);
	}
}
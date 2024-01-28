using System;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
public class Hole : MonoBehaviour
{
	[SerializeField] private string playerTag;

	public static Action PassedEvent;

	private void OnTriggerExit2D(Collider2D collision)
	{
		if (collision.tag == playerTag)
		{
			PassedEvent?.Invoke();
		}
	}
}
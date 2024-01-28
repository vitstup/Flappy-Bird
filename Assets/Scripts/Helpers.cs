using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public static class Helpers
{
	public static bool IsOverUI()
	{
		var _eventDataCurPos = new PointerEventData(EventSystem.current) { position = Input.mousePosition };
		var _results = new List<RaycastResult>();
		EventSystem.current.RaycastAll(_eventDataCurPos, _results);
		return _results.Count > 0;
	}
}
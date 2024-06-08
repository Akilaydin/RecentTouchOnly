using System;

using UnityEngine;
using UnityEngine.EventSystems;

namespace OriGames.RecentTouchOnlyInput
{
	public class RecentTouchOnlyInput : BaseInput
	{
		/// <summary>
		/// Fires every time the touch get cancelled and the recent one starts to process. Passes the touch that got cancelled
		/// </summary>
		public event Action<Touch> OnTouchCancel = delegate { }; 
		
		/// <summary>
		/// Returns the touch that is occuring currently
		/// </summary>
		public Touch MostRecentTouch => GetTouchByFingerId(_mostRecentTouchFingerId);
		
		private int _mostRecentTouchFingerId = -1;

		public void ProcessTouches()
		{
			for (int i = 0; i < touchCount; i++)
			{
				var touch = GetTouch(i);

				if (touch.phase != TouchPhase.Began)
				{
					continue;
				}

				OnTouchCancel.Invoke(GetTouchByFingerId(_mostRecentTouchFingerId));
                    
				_mostRecentTouchFingerId = touch.fingerId;
			}
		}

		private Touch GetTouchByFingerId(int fingerId)
		{
			foreach (var touch in Input.touches)
			{
				if (touch.fingerId == fingerId)
				{
					return touch;
				}
			}

			return default;
		}
	}
}

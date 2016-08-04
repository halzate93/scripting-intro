using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;

namespace Phys
{
	public class ClickTrigger : MonoBehaviour, IPointerClickHandler
	{
		[SerializeField]
		private ColorToggle colorToggle;

		public void OnPointerClick (PointerEventData eventData)
		{
			colorToggle.Toggle ();
		}
	}
}
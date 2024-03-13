using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;

namespace UnitySamples.Physics
{
	[RequireComponent (typeof (Renderer))]
	public class ColorToggle: MonoBehaviour
	{
		private bool isOn = true;
		private Renderer renderer;

		private void Awake ()
		{
			renderer = GetComponent<Renderer> ();
		}

		public void Toggle ()
		{
			isOn = !isOn;
			Color toSet = isOn ? Color.white : Color.black;
			SetColor (toSet);
		}

		private void SetColor (Color toSet)
		{
			renderer.material.color = toSet;
		}
	}
}
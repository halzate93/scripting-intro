using UnityEngine;
using System.Collections;

namespace AI
{
	public class CheckObstacle : Selector {
		[SerializeField]
		private float distance;

		protected override bool Check ()
		{
			RaycastHit hitInfo;
			bool hasObstacle = Physics.Raycast (transform.position, transform.forward, out hitInfo, distance);
			if (hasObstacle)
				Debug.Log (string.Format ("Has obstacle {0}", hitInfo.transform.name));
			return hasObstacle;
		}
	}
}
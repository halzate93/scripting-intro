using UnityEngine;
using System.Collections;

namespace AI
{
	public class MoveForward : Node
	{
		[SerializeField]
		private float distance;

		public override void Execute ()
		{
			transform.Translate (transform.forward * distance);
		}
	}
}
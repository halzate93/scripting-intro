using UnityEngine;
using System.Collections;

namespace AI
{
	public class Rotate : Node {
		
		public override void Execute ()
		{
			transform.Rotate (0f, 90f, 0f);
		}
	}
}
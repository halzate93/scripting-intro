
using UnityEngine;

namespace Animation
{
	[RequireComponent (typeof (Animator))]
	public class AnimationTest : MonoBehaviour
	{
		private Animator animator;

		private void Awake ()
		{
			animator = GetComponent<Animator> ();
		}
		
		void Update () {
			if (Input.GetKeyDown (KeyCode.Space))
				animator.SetTrigger ("Turn Red");
		}
	}
}
using UnityEngine;

namespace Phys
{
	[RequireComponent (typeof (Character2DController))]
	[RequireComponent (typeof (Animator))]
	public class CustomMovementPlayer : MonoBehaviour 
	{
		[SerializeField]
		private float jumpSpeed;
		[SerializeField]
		private float horizontalSpeed;
		private Character2DController controller;
		private Animator animator;

		private void Awake ()
		{
			controller = GetComponent<Character2DController> ();
			animator = GetComponent<Animator> ();
		}

		private void Update ()
		{
			float x = Input.GetAxis ("Horizontal");
			bool isJumping = Input.GetKeyDown (KeyCode.Space);
			Vector2 movement = new Vector2 (x * horizontalSpeed, isJumping? jumpSpeed : 0f);
			controller.Move (movement);
			UpdateAnimations (movement.x, controller.IsGrounded);
		}

		private void UpdateAnimations (float speed, bool isGrounded)
		{
			animator.SetFloat ("Speed", Mathf.Abs(speed));
			animator.SetBool ("Ground", isGrounded);
		}
	}
}
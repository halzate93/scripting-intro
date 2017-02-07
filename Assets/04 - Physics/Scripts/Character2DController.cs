using UnityEngine;

namespace Phys
{
	[RequireComponent (typeof (Collider2D))]
	public class Character2DController : MonoBehaviour 
	{
		[SerializeField]
		private float maxFloorDistance;
		[SerializeField]
		private Transform feet;
		[SerializeField]
		private float gravity;
		[SerializeField]
		private LayerMask ground;
		private Vector2 velocity;
		private Vector2 targetVelocity;
		private bool isFacingRight = true;

		public bool IsGrounded
		{
			get; private set;
		}

		private void FixedUpdate ()
		{
			IsGrounded = Physics2D.Raycast (feet.position, Vector2.down, maxFloorDistance, ground);
			if (IsGrounded)
				UpdateVelocity ();
			else
				velocity.y -= gravity * Time.fixedDeltaTime;
			if ((velocity.x > 0 && !isFacingRight) || (velocity.x < 0 && isFacingRight))
				Flip ();
			transform.Translate (velocity * Time.fixedDeltaTime);
		}

		private void OnDrawGizmos()
		{
			Debug.DrawLine (feet.position, (Vector2)feet.position + (Vector2.down * maxFloorDistance));
		}

		public void Move (Vector2 velocity)
		{
			targetVelocity = velocity;
		}

		private void UpdateVelocity ()
		{
			velocity = targetVelocity;
			targetVelocity = Vector2.zero;
		}

		private void Flip ()
		{
			Vector2 flipped = transform.localScale;
			flipped.x *= -1;
			transform.localScale = flipped;
			isFacingRight = !isFacingRight;
		}
	}
}
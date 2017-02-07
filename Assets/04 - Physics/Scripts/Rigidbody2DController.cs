using UnityEngine;

[RequireComponent (typeof (Rigidbody2D))]
public class Rigidbody2DController : MonoBehaviour
{
	[SerializeField]
	private float maxSpeed;
	[SerializeField]
	private float floorDistance;
	[SerializeField]
	private LayerMask ground;
	[SerializeField]
	private Transform feet;

	private new Rigidbody2D rigidbody;
	private bool isFacingRight = true;

	public bool IsGrounded
	{
		get; private set;
	}

	private void Awake ()
	{
		rigidbody = GetComponent <Rigidbody2D> ();
	}

	private void FixedUpdate ()
	{
		IsGrounded = Physics2D.Raycast (feet.position, Vector2.down, floorDistance, ground);
	}

	public void Move (Vector2 force)
	{
		if (!IsGrounded) return;
		if (Mathf.Abs(rigidbody.velocity.x) >= maxSpeed && force.x * rigidbody.velocity.x > 0)
			force.x = 0f;
		rigidbody.AddForce (force, ForceMode2D.Impulse);
		if ((rigidbody.velocity.x > 0 && !isFacingRight) || (rigidbody.velocity.x < 0 && isFacingRight))
			Flip ();	
	}

	private void Flip ()
	{
		Vector2 flipped = transform.localScale;
		flipped.x *= -1;
		transform.localScale = flipped;
		isFacingRight = !isFacingRight;
	}
}

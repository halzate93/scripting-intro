using UnityEngine;

namespace Phys
{
    [RequireComponent (typeof (Rigidbody2DController))]
    [RequireComponent (typeof (Animator))]
    public class RigidbodyPlayer: MonoBehaviour
    {
        [SerializeField]
        private float jumpForce;
        [SerializeField]
        private float moveForce;
        private Rigidbody2DController controller;
        private Animator animator;

        private void Awake ()
        {
            controller = GetComponent <Rigidbody2DController> ();
            animator = GetComponent <Animator> ();
        }

        private void Update ()
        {
            bool isJumping = Input.GetKeyDown (KeyCode.Space);
            float horizontal = Input.GetAxis ("Horizontal");
            Vector2 force = new Vector2 (horizontal * moveForce, isJumping? jumpForce : 0f);
            controller.Move (force * Time.deltaTime);
            UpdateAnimations (horizontal, controller.IsGrounded);
        }

        private void UpdateAnimations (float speed, bool isGrounded)
		{
			animator.SetFloat ("Speed", Mathf.Abs(speed));
			animator.SetBool ("Ground", isGrounded);
		}
    }
}
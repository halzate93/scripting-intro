using UnityEngine;

namespace Phys
{
	public class Gun : MonoBehaviour 
	{
		[SerializeField]
		private Rigidbody bullet;
		[SerializeField]
		private Transform gun;
		[SerializeField]
		private float force = 1f;

		private void Update ()
		{
			if (Input.GetKeyDown (KeyCode.Space))
				Shoot ();
		}

		private void Shoot ()
		{
			Rigidbody rigidbody = Instantiate (bullet, gun.position, transform.rotation);
			rigidbody.AddForce (transform.forward * force, ForceMode.Impulse);
		}
	}
}
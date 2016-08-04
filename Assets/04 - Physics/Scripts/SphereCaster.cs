using UnityEngine;
using System.Collections;

namespace Phys
{
	public class SphereCaster : MonoBehaviour {
		[SerializeField]
		private float radius = 5;

		private void Update () {
			if (Input.GetKeyDown (KeyCode.Space))
				Shoot ();
		}

		private void OnDrawGizmos ()
		{
			Debug.DrawRay (transform.position, transform.forward);
		}

		private void OnDrawGizmosSelected ()
		{
			Gizmos.color = Color.white;
			Gizmos.DrawWireSphere (transform.position, radius);
		}

		private void Shoot ()
		{
			RaycastHit[] hits = Physics.SphereCastAll (transform.position, radius, transform.forward);
			if (hits != null)
				DestroyEnemies (hits);
		}

		private void DestroyEnemies (RaycastHit[] hits)
		{
			foreach (RaycastHit hit in hits) {
				Destroy (hit.transform.gameObject);
			}
		}
	}
}
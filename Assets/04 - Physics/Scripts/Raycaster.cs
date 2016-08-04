using UnityEngine;
using System.Collections;

namespace Phys
{
	public class Raycaster : MonoBehaviour {
		private void Update () {
			if (Input.GetKeyDown (KeyCode.Space))
				Shoot ();
		}

		private void OnDrawGizmos ()
		{
			Debug.DrawRay (transform.position, transform.forward);
		}

		private void Shoot ()
		{
			RaycastHit hitInfo;
			bool didHit = Physics.Raycast (transform.position, transform.forward, out hitInfo);
			if (didHit) {
				Debug.Log (hitInfo.transform.gameObject.name);
			}
		}
	}
}
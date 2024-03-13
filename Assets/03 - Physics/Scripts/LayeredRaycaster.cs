using UnityEngine;
using System.Collections;

namespace UnitySamples.Physics
{
	public class LayeredRaycaster : MonoBehaviour 
	{
		[SerializeField]
		private LayerMask canHit;

		[SerializeField]
		private int range; 

		private void Update () {
			if (Input.GetKeyDown (KeyCode.Space))
				Shoot ();
		}

		private void OnDrawGizmos ()
		{
			Debug.DrawLine (transform.position, transform.position + transform.forward * range);
		}

		private void Shoot() 
		{
			RaycastHit hit;
			Ray ray = new Ray (transform.position, transform.forward);

			if (UnityEngine.Physics.Raycast(ray, out hit, range, canHit)) {
				Debug.Log (hit.transform.name);
			}
		}
	}
}
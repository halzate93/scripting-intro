using UnityEngine;
using System.Collections;

namespace Phys
{
	public class CollisionDebugger : MonoBehaviour {

		private void OnCollisionEnter (Collision collision)
		{
			Debug.Log ("Collision enter" + gameObject.name);
		}

		private void OnCollisionStay (Collision collision)
		{
			Debug.Log ("Collision stay" + gameObject.name);
		}

		private void OnCollisionExit (Collision collision)
		{
			Debug.Log ("Collision exit" + gameObject.name);
		}
	}
}
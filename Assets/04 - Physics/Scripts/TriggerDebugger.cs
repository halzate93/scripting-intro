using UnityEngine;
using System.Collections;

namespace Phys
{
	public class TriggerDebugger : MonoBehaviour {

		private void OnTriggerEnter (Collider collision)
		{
			Debug.Log ("Trigger enter" + gameObject.name);
		}

		private void OnTriggerStay (Collider collision)
		{
			Debug.Log ("Trigger stay" + gameObject.name);
		}

		private void OnTriggerExit (Collider collision)
		{
			Debug.Log ("Trigger exit" + gameObject.name);
		}
	}
}
using UnityEngine;

namespace UnitySamples.Physics
{
	public class Deathzone : MonoBehaviour 
	{
		private void OnTriggerEnter (Collider other)
		{
			Destroy (other.gameObject);
		}
	}
}
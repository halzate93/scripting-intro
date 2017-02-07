using UnityEngine;

namespace Phys
{
	public class Deathzone : MonoBehaviour 
	{
		private void OnTriggerEnter (Collider other)
		{
			Destroy (other.gameObject);
		}
	}
}
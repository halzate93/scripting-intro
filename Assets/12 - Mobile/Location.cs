using System.Collections;
using UnityEngine;

namespace Mobile
{
	public class Location : MonoBehaviour 
	{
		[SerializeField]
		private int maxWait = 20;
		private bool isReady;

		private void Start ()
		{
			StartCoroutine (StartService ());
		}

		private IEnumerator StartService ()
		{
			if (!Input.location.isEnabledByUser)
            	yield break;
			
			Input.location.Start();

			while (Input.location.status == LocationServiceStatus.Initializing && maxWait > 0)
			{
				yield return new WaitForSeconds(1);
				maxWait--;
			}

			if (maxWait < 1)
			{
				Debug.LogError ("Timed out");
				yield break;
			}

			if (Input.location.status == LocationServiceStatus.Failed)
			{
				Debug.LogError ("Unable to determine device location");
				yield break;
			}

			isReady = true;
			Debug.Log ("Got location");
		}

		private void Update ()
		{
			if (isReady)
				Debug.Log (Input.location.lastData);
			
			if (isReady && Input.GetKeyDown (KeyCode.S))
				StopService ();
			if (!isReady && Input.GetKeyDown (KeyCode.S))
				StartCoroutine (StartService ());
		}

		private void StopService ()
		{
			Input.location.Stop ();
			isReady = false;
		}
	}
}
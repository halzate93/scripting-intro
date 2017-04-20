using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Coroutines
{
	public class PrintWaitingTime : MonoBehaviour 
	{
		[SerializeField]
		private float seconds;
		private bool hasCooldown;
		private Coroutine cooldown;

		private void Update ()
		{
			if (Input.GetKeyDown (KeyCode.Space) && !hasCooldown)
			{
				Shoot ();
				cooldown = StartCoroutine (CoolDownRoutine (seconds));
			}

			if (Input.GetKeyDown (KeyCode.G))
				RestoresImmediate ();
		}

		private void Shoot ()
		{
			Debug.Log ("Shoot");
		}

		private IEnumerator CoolDownRoutine (float seconds)
		{
			hasCooldown = true;
			yield return StartCoroutine (WaitAndPrintRoutine (seconds));
			StopCoolDown ();
			hasCooldown = false;
		}

		private IEnumerator WaitAndPrintRoutine (float seconds)
		{
			while (seconds > 0f)
			{
				Debug.LogFormat ("Remaining: {0}", seconds);
				float waitTime = Mathf.Min(1f, seconds);
				seconds -= waitTime;
				yield return new WaitForSeconds (waitTime);
			}
		}

		private void RestoresImmediate ()
		{
			hasCooldown = false;
			StopCoolDown ();
		}

		private void StopCoolDown ()
		{
			StopCoroutine (cooldown);
			cooldown = null;
		}
	}
}
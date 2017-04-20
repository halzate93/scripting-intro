using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Mobile
{
	public class Accelerometer : MonoBehaviour 
	{
		private void Update () 
		{
			Debug.Log (GetAcceleration ());
		}

		private Vector3 GetAcceleration ()
		{
			#if !UNITY_EDITOR && (UNITY_ANDROID || UNITY_IPHONE)
				return Input.acceleration;
			#else
				return GetFakeAcceleration ();
			#endif
		}

		private Vector3 GetFakeAcceleration ()
		{
			float x = Input.GetAxis ("Horizontal");
			float y = Input.GetAxis ("Vertical");
			return new Vector3 (x, y, 0f);
		}

	}
}
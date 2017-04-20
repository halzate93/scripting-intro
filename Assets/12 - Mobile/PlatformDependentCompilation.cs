using UnityEngine;

namespace Mobile
{
	public class PlatformDependentCompilation : MonoBehaviour 
	{
		private void Start () 
		{
			#if UNITY_EDITOR && !UNITY_ANDROID
			Debug.Log ("Editor");
			#else
			Debug.Log ("Device");
			#endif
		}
	}
}
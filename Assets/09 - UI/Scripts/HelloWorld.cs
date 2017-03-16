using UnityEngine;

namespace UI
{
	public class HelloWorld : MonoBehaviour 
	{
		#if UNITY_EDITOR
		private void OnGUI ()
		{
			Vector2 center = new Vector2 (Screen.width/2f, Screen.height/2f);
			Rect position = new Rect (Screen.width/2f - Screen.width/16f, Screen.height/2f - 50f, Screen.width/8f, 100f);
			if (GUI.Button (position, "Hello"))
				Debug.Log ("Hello world!");
		}
		#endif
	}
}
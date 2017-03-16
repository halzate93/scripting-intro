using UnityEngine;
using UnityEngine.UI;

namespace UI
{
	[RequireComponent (typeof (Button))]
	public class ButtonTest : MonoBehaviour 
	{
		private Button button;
		
		private void Awake () 
		{
			button = GetComponent<Button> ();
			button.onClick.AddListener (OnClick);
		}
		
		private void OnClick ()
		{
			Debug.Log ("Hello world");
		}
	}
}
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
	[RequireComponent (typeof (Text))]
	public class TextTest : MonoBehaviour 
	{
		private Text text;
		private int count;

		private void Awake ()
		{
			text = GetComponent<Text> ();	
			Next ();
		}
		
		private void Update () 
		{
			if (Input.GetKeyDown (KeyCode.Space))
				Next ();
		}

		private void Next ()
		{
			count ++;
			text.text = count.ToString ();
		}
	}
}
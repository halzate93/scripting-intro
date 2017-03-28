using UnityEngine;
using UnityEngine.UI;

namespace UI
{
	[RequireComponent (typeof (InputField))]
	public class InputFieldTest : MonoBehaviour
	{
		private InputField input;

		private void Awake ()
		{
			input = GetComponent<InputField> ();
		}

		private void Update ()
		{
			if (Input.GetKeyDown (KeyCode.Space))
				Log ();
		}

		private void Log ()
		{
			Debug.Log (input.text);	
		}
	}
}
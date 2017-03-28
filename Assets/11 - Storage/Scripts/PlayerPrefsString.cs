using UnityEngine;

namespace Storage
{
	public class PlayerPrefsString : MonoBehaviour 
	{
		[SerializeField]
		private string username;

		private void Update ()
		{
			if (Input.GetKeyDown (KeyCode.S))
				Store ();
			if (Input.GetKeyDown (KeyCode.L))
				Load ();
		}

		private void Store ()
		{
			PlayerPrefs.SetString ("username", username);
		}

		private void Load ()
		{
			username = PlayerPrefs.GetString ("username");
		}
		
	}
}
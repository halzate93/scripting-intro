using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

namespace Storage
{
	public class FileUser : MonoBehaviour 
	{
		[SerializeField]
		private PlayerData player;


		private void Update ()
		{
			if (Input.GetKeyDown (KeyCode.S))
				Store ();
			if (Input.GetKeyDown (KeyCode.L))
				Load ();
		}

		private void Store ()
		{
			BinaryFormatter formatter =  new BinaryFormatter ();
			FileStream file = File.Open (Application.persistentDataPath + "/myfile.dat", FileMode.Open);
			formatter.Serialize (file, player);
			file.Close ();
		}

		private void Load ()
		{
			if (!File.Exists (Application.persistentDataPath + "/myfile.dat")) return;
			BinaryFormatter formatter =  new BinaryFormatter ();
			FileStream file = File.Open (Application.persistentDataPath + "/myfile.dat", FileMode.Open);
			player = (PlayerData)formatter.Deserialize (file);
			file.Close ();
		}
		
	}
}

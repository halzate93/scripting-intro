using UnityEngine;

namespace Storage
{
    public class PlayerPrefsUser: MonoBehaviour
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
            string json =  JsonUtility.ToJson (player);
            PlayerPrefs.SetString ("player", json);
        }

        private void Load ()
        {
            string json = PlayerPrefs.GetString ("player", "{}");
            player = JsonUtility.FromJson<PlayerData> (json);
        }
    }
}
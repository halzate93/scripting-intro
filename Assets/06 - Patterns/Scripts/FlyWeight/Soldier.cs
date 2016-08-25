using UnityEngine;
using System.Collections;

namespace Patterns
{
	public class Soldier : MonoBehaviour {
		public int life;
		public int attack;
		public int defense;

		public void Attack ()
		{
			Debug.Log ("Attack");	
		}

		public void Run ()
		{
			Debug.Log ("Run");	
		}
	}
}
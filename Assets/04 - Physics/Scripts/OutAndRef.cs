using UnityEngine;
using System.Collections;

namespace Phys
{
	public class OutAndRef : MonoBehaviour {

		// Use this for initialization
		private void Start () {
			int a = 2, b = 4;
			Debug.Log ("Add " + Add (a, b));

			int result;
			bool even = AddIfEvenNumbers (a, b, out result);
			Debug.Log (string.Format("Add using out - a: {0}, b: {1}, even: {2}, result: {3}",
				a, b, even, result));

			int oldB = b;
			even = AddIfEvenNumbers (a, ref b);
			Debug.Log (string.Format("Add using ref - a: {0}, oldB: {1}, even: {2}, b: {3}",
				a, oldB, even, b));
		}

		private int Add (int a, int b)
		{
			return a + b;		
		}

		private bool AddIfEvenNumbers (int a, int b, out int result)
		{
			bool even = (a % 2 == 0) && (b % 2 == 0);
//			if (even)
//				result = a + b;
//			else
//				result = -1;
			result = even? a + b : -1;
			b = 304352345;
			return even;
		}

		private bool AddIfEvenNumbers (int a, ref int b)
		{
			bool even = (a % 2 == 0) && (b % 2 == 0);
			b = even? b + a : -1;
			return even;
		}
	}
}
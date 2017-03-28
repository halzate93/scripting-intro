using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Structures
{
	public class HotDogCar : MonoBehaviour 
	{
		[SerializeField]
		private float timePerRequest = 1f;
		private Queue<Product> pendingRequests;
		private float elapsedTime;

		private void Awake ()
		{
			pendingRequests = new Queue<Product> ();
		}

		private void Update ()
		{
			elapsedTime += Time.deltaTime;
			if (pendingRequests.Count != 0 && elapsedTime >= timePerRequest)
			{
				Complete (pendingRequests.Dequeue ());
				elapsedTime = 0f;
			}
		}

		public void PlaceOrder (Product requested)
		{
			pendingRequests.Enqueue (requested);
			LogOrderEvent ("Placed", requested);
		}

		private void Complete (Product completed)
		{
			LogOrderEvent ("Completed", completed);
		}

		private void LogOrderEvent (string productEvent, Product product)
		{
			string message = string.Format ("{0} order: {1} pending: {2}", productEvent, product, pendingRequests.Count);
			Debug.Log (message);
		}
	}
}
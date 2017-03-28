using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Structures
{
	public class Manager : MonoBehaviour 
	{
		[SerializeField]
		private HotDogCar shop;
		[SerializeField]
		private Button orderTrigger;
		[SerializeField]
		private Dropdown products;

		private void Start ()
		{
			orderTrigger.onClick.AddListener (PlaceSelectedOrder);
			products.SetOptions<Product> ();
		}

		private void PlaceSelectedOrder ()
		{
			Product order = GetSelection ();
			shop.PlaceOrder (order);
		}

		private Product GetSelection ()
		{
			return products.GetValue <Product>();
		}
	}
}
using System;
using UnityEngine;

namespace Storage
{
	[CreateAssetMenu]
	public class InventoryData : ScriptableObject
	{
		[SerializeField]
		private Item[] items;
	}

	[Serializable]
	public class Item
	{
		public string name;
		public string type;
		public string description;
		public Sprite image;
	}
}
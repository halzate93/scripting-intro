using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace AI
{
	[RequireComponent (typeof(NavMeshAgent))]
	public class NavMeshAgentController : MonoBehaviour 
	{
		[SerializeField]
		private LayerMask walkable;
		private NavMeshAgent agent;

		private void Awake ()
		{
			agent = GetComponent<NavMeshAgent> ();
		}

		private void Update ()
		{
			if (Input.GetMouseButtonDown (0))
			{
				Vector3 position = GetPosition ();
				agent.SetDestination (position);
			}
		}

		private Vector3 GetPosition ()
		{
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			RaycastHit hit;
			if (Physics.Raycast (ray, out hit, walkable))
				return hit.point;
			else
				return transform.position;
		}
	}
}
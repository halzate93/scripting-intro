using UnityEngine;

namespace UnitySamples.Math
{
    public class PositionInterpolator : MonoBehaviour
    {
        [SerializeField]
        private Transform goal;

        [SerializeField]
        private float time;

        [SerializeField]
        private bool sphericalInterpolation;

        private Vector3 initialPosition;
        private float elapsedTime;

        private void Start()
        {
            initialPosition = transform.position;
        }

        private void Update()
        {
            elapsedTime += Time.deltaTime;
            if (!sphericalInterpolation)
                transform.position = Vector3.Lerp(initialPosition, goal.position, elapsedTime / time);
            else
                transform.position = Vector3.Slerp(initialPosition, goal.position, elapsedTime / time);
        }
    }
}
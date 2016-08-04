using UnityEngine;

namespace Math
{
    public class ViewRange : MonoBehaviour
    {

        [SerializeField]
        private float viewAngle;

        private void OnDrawGizmos()
        {
            Debug.DrawRay(transform.position, transform.forward);
        }

        private void OnTriggerStay(Collider collider)
        {
            if (IsInRange(collider.transform.position))
                Debug.Log("Sees something");
        }

        private bool IsInRange(Vector3 seenPosition)
        {
            Vector3 direction = seenPosition - transform.position;
            float angle = Vector3.Angle(transform.forward, direction);
            Debug.Log(angle);
            return angle <= viewAngle / 2;
        }
    }
}
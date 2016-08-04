using UnityEngine;

namespace Math
{
    public class Rotating : MonoBehaviour
    {

        [SerializeField]
        private Vector3 rotationSpeed;

        private void Update()
        {
            transform.Rotate(rotationSpeed * Time.deltaTime);
        }
    }
}
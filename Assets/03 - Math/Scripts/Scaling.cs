using UnityEngine;

namespace Math
{
    public class Scaling : MonoBehaviour
    {
        [SerializeField]
        private float scalingSpeed;

        private void Update()
        {
            transform.localScale *= scalingSpeed * (1 + Time.deltaTime);
        }
    }
}
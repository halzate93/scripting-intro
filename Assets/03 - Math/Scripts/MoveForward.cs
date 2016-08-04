using UnityEngine;

namespace Math
{
    public class MoveForward : MonoBehaviour
    {

        [SerializeField]
        private float speed;

        private void Update()
        {
            transform.Translate(transform.forward * speed * Time.deltaTime);
        }
    }
}
using UnityEngine;

namespace Mobile
{
    public class Accelerometer : MonoBehaviour
    { 
        [SerializeField]
        private  float speed = 10.0F;

        private void Update()
        {
            Vector3 dir = Vector3.zero;
            dir.y = Input.acceleration.y;
            dir.x = Input.acceleration.x;
            if (dir.sqrMagnitude > 1)
                dir.Normalize();

            dir *= speed;
            transform.Translate(dir * Time.deltaTime);
        }
    }
}
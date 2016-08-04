using UnityEngine;

namespace Math
{
    public class Aiming : MonoBehaviour
    {
        private void Update()
        {
            Vector3 direction = GetMouseAiming();
            transform.LookAt(direction);
        }

        private Vector3 GetMouseAiming()
        {
            Vector3 center = new Vector3(Screen.width / 2, Screen.height / 2);
            Vector3 direction = (Input.mousePosition - center).normalized;
            Debug.Log(direction);
            return direction;
        }
    }
}
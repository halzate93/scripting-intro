using UnityEngine;

namespace Intro
{
    public class ButtonsAndAxesTrigger : MonoBehaviour
    {
        private void Update()
        {
            if (Input.GetButtonDown("Fire1"))
                Debug.Log("Fire");

            Vector2 movement;
            movement.x = Input.GetAxis("Horizontal");
            movement.y = Input.GetAxis("Vertical");

            Debug.Log("x: " +movement.x + " , y: " +movement.y);
        }
    }
}
using UnityEngine;
using System.Collections;
using System;

namespace Phys
{
    [RequireComponent (typeof (CharacterController))]
    public class PlayerMovement : MonoBehaviour
    {
        [SerializeField]
        private float rapidity = 10f;

        [SerializeField]
        private float jumpSpeed = 10f;

        [SerializeField]
        private float gravity = 2f;

        private float currentVerticalSpeed;

        private CharacterController controller;

        private void Awake()
        {
            controller = GetComponent<CharacterController>();
        }

        private void Update()
        {
            float x = Input.GetAxis("Horizontal");
            float z = Input.GetAxis("Vertical");
            

            Vector3 horizontalSpeed = new Vector3(x, 0, z) * rapidity;
            Vector3 verticalSpeed = GetVerticalSpeed() * Vector3.up;
            Vector3 speed = horizontalSpeed + verticalSpeed;

            controller.Move(speed * Time.deltaTime);
        }

        private float GetVerticalSpeed()
        {
            if (controller.isGrounded)
            {
                if (Input.GetKeyDown (KeyCode.Space))
                    currentVerticalSpeed = jumpSpeed;
                else
                    currentVerticalSpeed = 0;
            }
            else
                currentVerticalSpeed -= gravity * Time.deltaTime;
            return currentVerticalSpeed;
        }
    }
}
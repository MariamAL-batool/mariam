using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace popup
{
    public class TheCamera : MonoBehaviour
    {
        public GameObject meme; // Object to look at
        public float speed = 10f; // Movement speed
        public float smoothFactor = 0.125f; // Smoothing factor for movement

        private Vector3 targetPosition;

        void Start()
        {
            targetPosition = transform.position; // Initialize target position
        }

        void Update()
        {
            // Look at the target object
            if (meme != null)
            {
                transform.LookAt(meme.transform);
            }

            // Process input for movement
            Vector3 movement = Vector3.zero;

            if (Input.GetKey(KeyCode.W))
            {
                movement += Vector3.left;
            }
            if (Input.GetKey(KeyCode.S))
            {
                movement += Vector3.right;
            }
            if (Input.GetKey(KeyCode.E))
            {
                movement += Vector3.up;
            }
            if (Input.GetKey(KeyCode.Q))
            {
                movement += Vector3.down;
            }
            if (Input.GetKey(KeyCode.D))
            {
                movement += Vector3.forward;
            }
            if (Input.GetKey(KeyCode.A))
            {
                movement += Vector3.back;
            }

            // Update target position
            targetPosition += movement * speed * Time.deltaTime;

            // Smoothly move the camera towards the target position
            transform.position = Vector3.Lerp(transform.position, targetPosition, smoothFactor);
        }
    }
}

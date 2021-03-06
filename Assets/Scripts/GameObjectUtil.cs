﻿using UnityEngine;

namespace Assets
{
    internal class GameObjectUtil : MonoBehaviour
    {
        public static float distanceToGround = 0.5f;

        private static Vector3 defaultRotation = new Vector3(0f, 0f, 0f);

        public static bool isGrounded(Transform transform)
        {
            return Physics.Raycast(transform.position, Vector3.down, distanceToGround + 0.1f);
        }

        public static void Respawn(Transform transform)
        {
            Vector3 spawn = new Vector3(0f, 2f, 0f);

            transform.position = spawn;
            transform.rotation = Quaternion.Euler(defaultRotation);
        }

        public static void Flip(Transform transform)
        {
            if (Vector3.Dot(transform.up, Vector3.down) > 0)
            {
                Debug.Log("flip");
                transform.position += new Vector3(0f, 2f, 0f);
                transform.rotation = Quaternion.Euler(defaultRotation);
            }
        }
    }
}
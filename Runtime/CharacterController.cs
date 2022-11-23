using UnityEngine;

namespace Studio23.TestPackage
{
    public class CharacterController : MonoBehaviour
    {
        public static float MoveMentSpeed = 2.5f;

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                transform.position += new Vector3(0, 2.5f, 0f);
            }
        }
    }
}

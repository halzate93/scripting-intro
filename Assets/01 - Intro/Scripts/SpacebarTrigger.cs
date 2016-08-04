using UnityEngine;

namespace Intro
{
    public class SpacebarTrigger : MonoBehaviour
    {
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Debug.Log("Key down");
            }
            else if (Input.GetKey(KeyCode.Space))
            {
                Debug.Log("Key pressed");
            }
            else if (Input.GetKeyUp(KeyCode.Space))
            {
                Debug.Log("Key up");
            }
        }
    }
}
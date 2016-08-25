using UnityEngine;

namespace Mobile
{
    public class Touches : MonoBehaviour
    {
        private void Start()
        {
            Input.simulateMouseWithTouches = true;
        }

        private void Update()
        {
            foreach (Touch touch in Input.touches)
            {
                string touchInfo = string.Format("id: {0}, position: {1}, phase: {2}", touch.fingerId, touch.position, touch.phase);
                Debug.Log(touchInfo);
            }
        }
    }
}
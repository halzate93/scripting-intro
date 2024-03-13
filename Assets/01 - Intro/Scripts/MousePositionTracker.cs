using UnityEngine;

namespace UnitySamples.Intro
{
    public class MousePositionTracker : MonoBehaviour
    {
        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
                Debug.Log("Pressed left click.");

            Vector2 pos = Input.mousePosition;
            Debug.Log("x: " + pos.x + ", y: " +pos.y);
        }
    }
}
using UnityEngine;

namespace Intro
{
    public class EventsDebug : MonoBehaviour
    {
        private void Awake ()
        {
            Debug.Log ("Awake");
        }

        private void Start ()
        {
            Debug.Log("Start");
        }

        private void Update ()
        {
            Debug.Log("Update");
        }
    }
}
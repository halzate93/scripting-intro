using UnityEngine;
using System.Collections;

namespace Mobile
{
    public class Location : MonoBehaviour
    {
        private bool initialized;

        private void Start()
        {
            Input.location.Start();
            StartCoroutine(WaitForInitialization ());
        }

        private IEnumerator WaitForInitialization()
        {
            while (Input.location.status == LocationServiceStatus.Initializing)
            {
                Debug.Log("Waiting for initialization");
                yield return new WaitForSeconds(1f);
            }
            switch (Input.location.status)
            {
                case LocationServiceStatus.Failed:
                    Debug.LogWarning("Failed");
                    break;
                case LocationServiceStatus.Running:
                    initialized = true;
                    Debug.Log("Initialized");
                    break;
                default:
                    Debug.LogWarning("Stopped right away");
                    break;
            }
        }

        private void Update()
        {
            if (initialized)
            {
                LocationInfo data = Input.location.lastData;
                string location = string.Format("pos: {0}, {1}", data.latitude, data.longitude);
            }
        }
    }
}
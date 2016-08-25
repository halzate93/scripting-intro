using UnityEngine;
using System.Collections;

public class CameraFitter : MonoBehaviour {

    private Camera camera;

    private void Awake()
    {
        camera = GetComponent<Camera>();
    }

	private void Start () {
        camera.aspect = 16f / 9;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

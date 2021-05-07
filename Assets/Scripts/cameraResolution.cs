using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]

public class cameraResolution : MonoBehaviour
{
    public float sceneWidth = 10f;

    public float horizontalFOV = 90.0f;

    Camera myCamera;
    
    // Start is called before the first frame update
    void Start()
    {
        myCamera = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        float halfWidth = Mathf.Tan(0.5f * horizontalFOV * Mathf.Deg2Rad);

        float halfHeight = halfWidth * Screen.height / Screen.width;

        float verticalFOV = 2.0f * Mathf.Atan(halfHeight) * Mathf.Rad2Deg;

        myCamera.fieldOfView = verticalFOV;
    }
}

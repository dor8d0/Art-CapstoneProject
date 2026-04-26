using UnityEngine;

public class ScaleBackgroundToCamera : MonoBehaviour
{
    // Reference to the main camera, can be assigned in the Inspector
    public Camera mainCamera; 

    void Start()
    {
        if (mainCamera == null)
        {
            mainCamera = Camera.main; // Automatically find the main camera if not assigned
        }

        ScaleBackground();
    }

    // Call this method if the screen size changes dynamically at runtime
    void Update()
    {
        ScaleBackground();
    }

    void ScaleBackground()
    {
        // Calculate the height of the camera view in world units
        float cameraHeight = mainCamera.orthographicSize * 2;

        // Calculate the width based on the camera's aspect ratio
        float cameraWidth = cameraHeight * mainCamera.aspect; 

        // Assuming the default Unity Plane is 10 units wide and 10 units high
        // We need to scale the plane to match the calculated camera width and height
        // The default plane scale is usually 1, we divide by 10 (the default size in world units)
        transform.localScale = new Vector3(cameraWidth / 10f, cameraHeight / 10f, 1);
    }
}

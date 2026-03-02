using UnityEngine;
using UnityEngine.UI; // Required for Slider

public class RotateWithSlider : MonoBehaviour
{
    [Header("UI Slider Reference")]
    public Slider rotationSlider; // Assign in Inspector

    [Header("Rotation Settings")]
    public bool rotateAroundZ = true; // For 2D, Z-axis is typical
    public float minRotation = 0f;    // Minimum rotation angle
    public float maxRotation = 180f;  // Maximum rotation angle

    private void Start()
    {
        if (rotationSlider == null)
        {
            Debug.LogError("Rotation Slider is not assigned!");
            enabled = false;
            return;
        }

        // Set slider limits
        rotationSlider.minValue = minRotation;
        rotationSlider.maxValue = maxRotation;

        // Add listener for slider value changes
        rotationSlider.onValueChanged.AddListener(OnSliderValueChanged);
    }

    private void OnSliderValueChanged(float value)
    {
        // Rotate object based on slider value
        if (rotateAroundZ)
        {
            transform.rotation = Quaternion.Euler(0f, 0f, value);
        }
        else
        {
            // Example: Rotate around X axis
            transform.rotation = Quaternion.Euler(value, 0f, 0f);
        }
    }
}

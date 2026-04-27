using UnityEngine;
using UnityEngine.Rendering.Universal; // Essential for Light2D

public class LightCycler : MonoBehaviour
{
    private Light2D spotLight; 
    private int state = 0; // 0 = Off, 1 = Red, 2 = Blue

    void Start()
    {
        // Automatically finds the "Spot Light 2D" object by its name
        GameObject lightObject = GameObject.Find("Spot Light 2D");
        
        if (lightObject != null)
        {
            spotLight = lightObject.GetComponent<Light2D>();
        }
        else
        {
            Debug.LogError("Could not find object named 'Spot Light 2D'");
        }
    }

    // This method is called by the UI Button
    public void CycleLightColor()
    {
        if (spotLight == null) return;

        // Cycle through 3 states: 0 -> 1 -> 2 -> 0
        state = (state + 1) % 3;

        switch (state)
        {
            case 0: // OFF
                spotLight.color = Color.black; // Make it dark
                spotLight.intensity = 0f;      // Turn off light contribution
                break;
            case 1: // RED
                spotLight.color = Color.red;
                spotLight.intensity = 1f;
                break;
            case 2: // BLUE
                spotLight.color = Color.blue;
                spotLight.intensity = 1f;
                break;
            case 3: // YELLOW
                spotLight.color = Color.yellow;
                spotLight.intensity = 1f;
                break;
        }
    }
}

using UnityEngine;
using UnityEngine.Rendering.Universal;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ColorSelectionHandler : MonoBehaviour
{
    [Header("Lighting")]
    public Light2D spotLight; 
    
    [Header("UI Buttons")]
    public Button colorCycleButton;  
    public Button confirmButton;    

    [Header("Text")]
    public Text confirmButtonText;         

    // STATE DEFINITION: 0 = Off, 1 = Red, 2 = Blue
    private int state = 0; 

    void Start()
    {
        // --- AUTO-FIND REFERENCES ---
        if (spotLight == null)
            spotLight = GameObject.Find("Spot Light 2D")?.GetComponent<Light2D>();

        if (colorCycleButton == null)
            colorCycleButton = GameObject.Find("Color Button")?.GetComponent<Button>();

        if (confirmButton == null)
            confirmButton = GameObject.Find("Confirm Button")?.GetComponent<Button>();

        if (confirmButtonText == null && confirmButton != null)
            confirmButtonText = confirmButton.GetComponentInChildren<Text>();

        // --- CODE-BASED BUTTON ASSIGNMENT ---
        // This replaces needing to set them up in the Inspector
        if (colorCycleButton != null)
        {
            colorCycleButton.onClick.RemoveAllListeners(); // Clear old actions
            colorCycleButton.onClick.AddListener(CycleLightColor);
        }

        if (confirmButton != null)
        {
            confirmButton.onClick.RemoveAllListeners(); // Clear old actions
            confirmButton.onClick.AddListener(ConfirmSelection);
        }

        // --- SETUP INITIAL STATE ---
        if (confirmButton != null)
        {
            confirmButton.gameObject.SetActive(true);
            if(confirmButtonText != null) confirmButtonText.text = "Select Color";
        }
        
        if (spotLight != null)
        {
            spotLight.color = Color.black;
            spotLight.intensity = 0f;
        }
    }

    public void CycleLightColor()
    {
        if (spotLight == null) return;

        // Cycle through states: 0 -> 1 -> 2 -> 0
        state = (state + 1) % 3;
        Debug.Log("Current State Integer: " + state);

        switch (state)
        {
            case 0: // OFF
                spotLight.color = Color.black;
                spotLight.intensity = 0f;
                if(confirmButtonText != null) confirmButtonText.text = "Select Color";
                break;
            case 1: // RED
                spotLight.color = Color.red;
                spotLight.intensity = 1f;
                if(confirmButtonText != null) confirmButtonText.text = "Confirm Red";
                break;
            case 2: // BLUE
                spotLight.color = Color.blue;
                spotLight.intensity = 1f;
                if(confirmButtonText != null) confirmButtonText.text = "Confirm Blue";
                break;
        }
    }

    public void ConfirmSelection()
    {
        Debug.Log("Confirm Clicked. State is: " + state);

        if (state == 1) // RED
        {
            SceneManager.LoadScene("RedScene");
        }
        else if (state == 2) // BLUE
        {
            SceneManager.LoadScene("BlueScene");
        }
        else // OFF
        {
            Debug.Log("No color selected yet. Current state: " + state);
        }
    }
}
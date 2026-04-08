using UnityEngine;
using UnityEngine.Rendering.Universal;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ColorSelectionHandler : MonoBehaviour
{
    [Header("Lighting")]
    public Light2D spotLight;
    public float onIntensity = 1f;
    public float offIntensity = 0f;

    [Header("UI Buttons")]
    public Button redButton;
    public Button blueButton;
    public Button yellowButton;
    public Button confirmButton;

    [Header("Text")]
    public Text confirmButtonText;

    // STATE: 0 = Off, 1 = Red, 2 = Blue, 3 = Yellow
    private int state = 0;
    private string selectedName = "";

    void Start()
    {
        // Auto-find references if not assigned in Inspector
        if (spotLight == null)
            spotLight = GameObject.Find("Spot Light 2D")?.GetComponent<Light2D>();

        // Fallback: find any Light2D in scene
        if (spotLight == null)
        {
            spotLight = FindObjectOfType<Light2D>();
            if (spotLight != null)
                Debug.Log("Found Light2D on GameObject: " + spotLight.gameObject.name);
            else
                Debug.LogWarning("No Light2D found in scene. Assign `spotLight` in the Inspector.");
        }

        if (redButton == null)
            redButton = GameObject.Find("Red Button")?.GetComponent<Button>();

        if (blueButton == null)
            blueButton = GameObject.Find("Blue Button")?.GetComponent<Button>();

        if (yellowButton == null)
        {
            yellowButton = GameObject.Find("Yellow Button")?.GetComponent<Button>();
            if (yellowButton == null)
                yellowButton = GameObject.Find("Green Button")?.GetComponent<Button>();
        }

        if (confirmButton == null)
            confirmButton = GameObject.Find("Confirm Button")?.GetComponent<Button>();

        if (confirmButtonText == null && confirmButton != null)
            confirmButtonText = confirmButton.GetComponentInChildren<Text>();

        // Wire up listeners in code so scene setup isn't required
        if (redButton != null)
        {
            redButton.onClick.RemoveAllListeners();
            redButton.onClick.AddListener(() => SetSelectedColor(Color.red, "Red", 1));
        }

        if (blueButton != null)
        {
            blueButton.onClick.RemoveAllListeners();
            blueButton.onClick.AddListener(() => SetSelectedColor(Color.blue, "Blue", 2));
        }

        if (yellowButton != null)
        {
            yellowButton.onClick.RemoveAllListeners();
            yellowButton.onClick.AddListener(() => SetSelectedColor(Color.yellow, "Yellow", 3));
        }

        if (confirmButton != null)
        {
            confirmButton.onClick.RemoveAllListeners();
            confirmButton.onClick.AddListener(ConfirmSelection);
            confirmButton.gameObject.SetActive(true);
        }

        // Initial UI
        if (confirmButtonText != null)
            confirmButtonText.text = "Select Color";

        if (spotLight != null)
        {
            spotLight.color = Color.black;
            spotLight.intensity = onIntensity;
        }
    }

    // Centralized handler called by each color button
    public void SetSelectedColor(Color color, string name, int newState)
    {
        if (spotLight == null)
        {
            Debug.LogWarning("SpotLight reference missing.");
            return;
        }

        // If the same color button is pressed while active, turn the light off
        if (state == newState)
        {
            state = 0;
            selectedName = "";
            spotLight.color = Color.black;
            spotLight.intensity = 0f;
            if (confirmButtonText != null)
                confirmButtonText.text = "Select Color";
            return;
        }

        // Otherwise set the selected color
        state = newState;
        selectedName = name;
        spotLight.color = color;
        spotLight.intensity = 1f;

        if (confirmButtonText != null)
            confirmButtonText.text = "Confirm " + name;
    }

    public void ConfirmSelection()
    {
        Debug.Log("Confirm Clicked. State is: " + state + ", Name: " + selectedName);

        if (spotLight == null)
        {
            Debug.LogWarning("SpotLight reference missing.");
            return;
        }

        if (state == 0)
        {
            Debug.Log("No color selected.");
            return;
        }

        GameData.selectedColor = spotLight.color;
        GameData.selectedIntensity = spotLight.intensity;
        GameData.selectedColorState = state;
        GameData.savedStates.Add(state); //appends the selected state to the list of past states
        GameData.savedColors.Add(spotLight.color); //appends the selected color to the list of saved colors

        // Load scene based on selected color. Update scene names if your project uses different names.
        switch (state)
        {
            case 1:
                SceneManager.LoadScene("RedScene");
                break;
            case 2:
                SceneManager.LoadScene("RedScene");
                break;
            case 3:
                SceneManager.LoadScene("RedScene");
                break;
            default:
                Debug.LogWarning("Unknown color state: " + state);
                break;
        }
    }
}
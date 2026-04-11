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
        // Auto-find references if not assigned
        if (spotLight == null)
            spotLight = GameObject.Find("Spot Light 2D")?.GetComponent<Light2D>();

        if (spotLight == null)
        {
            spotLight = FindObjectOfType<Light2D>();
            if (spotLight != null)
                Debug.Log("Found Light2D on: " + spotLight.gameObject.name);
            else
                Debug.LogWarning("No Light2D found.");
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

        // Button listeners
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
            spotLight.intensity = offIntensity;
        }
    }

    // Handle color selection
    public void SetSelectedColor(Color color, string name, int newState)
    {
        if (spotLight == null)
        {
            Debug.LogWarning("SpotLight missing.");
            return;
        }

        // Toggle OFF if same button pressed
        if (state == newState)
        {
            state = 0;
            selectedName = "";
            spotLight.color = Color.black;
            spotLight.intensity = offIntensity;

            if (confirmButtonText != null)
                confirmButtonText.text = "Select Color";

            return;
        }

        // Set new color
        state = newState;
        selectedName = name;
        spotLight.color = color;
        spotLight.intensity = onIntensity;

        if (confirmButtonText != null)
            confirmButtonText.text = "Confirm " + name;
    }

    public void ConfirmSelection()
    {
        Debug.Log("Confirm Clicked. State: " + state);

        if (spotLight == null)
        {
            Debug.LogWarning("SpotLight missing.");
            return;
        }

        if (state == 0)
        {
            Debug.Log("No color selected.");
            return;
        }

        // Save data
        GameData.selectedColor = spotLight.color;
        GameData.selectedIntensity = spotLight.intensity;
        GameData.selectedColorState = state;

        GameData.savedStates.Add(state);
        GameData.savedColors.Add(spotLight.color);

        int choiceCount = GameData.savedStates.Count;
        Debug.Log("Total choices: " + choiceCount);

        // Scene list (ORDER MATTERS)
        string[] scenes = { 
            "RedScene", 
            "Second Scene", 
            "Third Scene", 
            "Fourth Scene",
            "End Scene"
        };

        int index = choiceCount - 1;

        if (index < scenes.Length)
        {
            SceneManager.LoadScene(scenes[index]);
        }
        else
        {
            SceneManager.LoadScene("End Scene");
        }
    }
}
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using TMPro;

public class Epilogue : MonoBehaviour
{
    public TMP_Text epilogueText;
    private int currentState = 2;

    public string[] yellowMessages = new string[]
    {
        "Against all odds, you turned the fairy tale into a feel-good ending.",
        "You somehow made it out smiling.",
        "Everyday is an opportunity for a \"Happily ever after.\""
    };

    public string[] redMessages = new string[]
    {
        "You did not choose peace, and the game definitely noticed.",
        "You brought chaos, and chaos brought you home.",
        "Some stories end happily. Yours did not."
    };

    public string[] blueMessages = new string[]
    {
        "You chose the quiet path, and somehow that said the most.",
        "I guess that's one way of saying good-bye.",
        "And just like that the story was beautiful, but it was over."
    };

    void Awake()
    {
        if (epilogueText == null)
        {
            CreateRuntimeText();
        }
    }

    void Start()
    {
        string message = GetEpilogueMessage();
        if (epilogueText != null)
        {
            epilogueText.text = message;
            SetTextColor(currentState);
        }
        else
        {
            Debug.Log(message);
        }
    }

    void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            SceneManager.LoadScene("Credits");
        }
    }

    private string GetEpilogueMessage()
    {
        int redCount = 0;
        int blueCount = 0;
        int yellowCount = 0;

        foreach (int savedState in GameData.savedStates)
        {
            switch (savedState)
            {
                case 1:
                    redCount++;
                    break;
                case 2:
                    blueCount++;
                    break;
                case 3:
                    yellowCount++;
                    break;
            }
        }

        int maxCount = Mathf.Max(redCount, blueCount, yellowCount);
        if (maxCount == 0)
        {
            return "Epilogue could not determine your path. No color choices were recorded.";
        }

        System.Collections.Generic.List<int> topStates = new System.Collections.Generic.List<int>();
        if (redCount == maxCount) topStates.Add(1);
        if (blueCount == maxCount) topStates.Add(2);
        if (yellowCount == maxCount) topStates.Add(3);

        int chosenState = topStates[Random.Range(0, topStates.Count)];
        currentState = chosenState;

        string[] choices = chosenState switch
        {
            1 => redMessages,
            2 => blueMessages,
            3 => yellowMessages,
            _ => blueMessages
        };

        string label = chosenState switch
        {
            1 => "RED:",
            2 => "BLUE:",
            3 => "YELLOW:",
            _ => "BLUE:"
        };

        int messageIndex = Random.Range(0, choices.Length);
        return $"<b>{label}</b>\n{choices[messageIndex]}";
    }

    private void SetTextColor(int state)
    {
        if (epilogueText == null) return;

        epilogueText.color = state switch
        {
            1 => Color.red,
            2 => Color.cyan,
            3 => new Color(1f, 0.85f, 0f),
            _ => Color.white,
        };
    }

    private void CreateRuntimeText()
    {
        Canvas canvas = FindObjectOfType<Canvas>();
        if (canvas == null)
        {
            GameObject canvasObject = new GameObject("EpilogueCanvas");
            canvas = canvasObject.AddComponent<Canvas>();
            canvas.renderMode = RenderMode.ScreenSpaceOverlay;
            canvasObject.AddComponent<CanvasScaler>();
            canvasObject.AddComponent<GraphicRaycaster>();
        }

        GameObject textObject = new GameObject("EpilogueText");
        textObject.transform.SetParent(canvas.transform, false);
        epilogueText = textObject.AddComponent<TextMeshProUGUI>();
        epilogueText.fontSize = 72;
        epilogueText.enableAutoSizing = true;
        epilogueText.fontSizeMin = 40;
        epilogueText.fontSizeMax = 96;
        epilogueText.alignment = TextAlignmentOptions.Center;
        epilogueText.color = Color.white;
        epilogueText.enableWordWrapping = true;
        RectTransform rect = epilogueText.rectTransform;
        rect.anchorMin = new Vector2(0.08f, 0.3f);
        rect.anchorMax = new Vector2(0.92f, 0.75f);
        rect.anchoredPosition = Vector2.zero;
        rect.sizeDelta = new Vector2(0, 0);
    }
}

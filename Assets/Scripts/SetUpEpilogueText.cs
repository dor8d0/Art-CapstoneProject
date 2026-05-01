using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;
using TMPro;
using System.Linq;

public class SetUpEpilogueText : MonoBehaviour
{
    public TextMeshProUGUI textMesh;
    public TMP_Text epilogueText;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        int[] intarray = GameData.savedStates.ToArray();
        string message = null;

        if (intarray.SequenceEqual(new int[] { 3 })) //yellow
        {
            message = "<color=yellow>Turns out the Big Bad Wolf was actually Little Red Riding Hood's puppy!</color>";
        }
        else if (intarray.SequenceEqual(new int[] { 1, 3 })) //red, yellow
        {
            message = "<color=red>Little Red Riding ran into the Big Bad Wolf and almost got eaten before running away!\n</color>" +
                "<color=yellow>But when he got to Grandma's house, she gave him some food anyways! Guess someone got a happy ending.</color>";
        }
        else if (intarray.SequenceEqual(new int[] { 2, 3 })) //blue, yellow
        {
            message = "<color=blue>Little Red Riding Hood got scared by the Big Bad Wolf and ran away.</color>\n" +
                "<color=yellow>But it turns out that the wolf was Red Riding Hood the whole time! Guess that girl was some random person.</color>";
        }
        else if (intarray.SequenceEqual(new int[] { 1, 1, 1 })) //red, red, red
        {
            message = "<color=red>Little Red Riding ran into the Big Bad Wolf and almost got eaten before running away!</color>\n" +
                "<color=red>The Wolf then went to Grandma's house, kicked the door down, and ate her!</color>\n" +
                "<color=red>When Little Red got to Grandma's house, the wolf was impersonating her and tried to eat Little Red! But suddenly a hunter appeared, scaring the wolf so bad he threw up the Grandma and fainted!</color>";

        }
        else if (intarray.SequenceEqual(new int[] { 1, 1, 2 })) //red, red, blue
        {
            message = "<color=red>Little Red Riding ran into the Big Bad Wolf and almost got eaten before running away!</color>\n" +
                "<color=red>The Wolf then went to Grandma's house, kicked the door down, and ate her!</color>\n" +
                "<color=blue>When Little Red got to Grandma's house, the wolf was impersonating her and tried to eat Little Red! But suddenly a hunter appeared, and the wolf ran away.</color>";
        }
        else if (intarray.SequenceEqual(new int[] { 1, 1, 3 })) //red, red, yellow
        {
            message = "<color=red>Little Red Riding ran into the Big Bad Wolf and almost got eaten before running away!</color>\n" +
                "<color=red>The Wolf then went to Grandma's house, kicked the door down, and ate her!</color>\n" +
                "<color=yellow>The Wolf proceeded to enjoy a yummy feast! Guess someone got a happy ending.</color>";
        }
        else if (intarray.SequenceEqual(new int[] { 1, 2, 1 })) //red, blue, red
        {
            message = "<color=red>Little Red Riding ran into the Big Bad Wolf and almost got eaten before running away!</color>\n" +
                "<color=blue>The Wolf then went to Grandma's house, kicked the door down, and ate her!</color>\n" +
                "<color=red>When Little Red got to Grandma's house, the wolf was impersonating her and tried to eat Little Red! But suddenly a hunter appeared, scared the wolf so bad he threw up the Grandma and fainted!</color>";
        }
        else if (intarray.SequenceEqual(new int[] { 1, 2, 2 })) //red, blue, blue
        {
            message = "<color=red>Little Red Riding ran into the Big Bad Wolf and almost got eaten before running away!</color>\n" +
                "<color=blue>The Wolf then went to Grandma's house, kicked the door down, and ate her!</color>\n" +
                "<color=blue>When Little Red got to Grandma's house, the wolf was impersonating her and tried to eat Little Red! But suddenly a hunter appeared, and the wolf ran away.</color>";
        }
        else if (intarray.SequenceEqual(new int[] { 1, 2, 3 })) //red, blue, yellow
        {
            message = "<color=red>Little Red Riding ran into the Big Bad Wolf and almost got eaten before running away!</color>\n" +
                "<color=blue>The Wolf then went to Grandma's house, kicked the door down, and ate her!</color>\n" +
                "<color=yellow>The Wolf proceeded to enjoy a yummy feast! Guess someone got a happy ending.</color>";
        }
        else if (intarray.SequenceEqual(new int[] { 2, 1, 1 })) //blue, red, red
        {
            message = "<color=blue>Little Red Riding Hood got scared by the Big Bad Wolf and ran away.</color>\n" +
                "<color=red>The Wolf then went to Grandma's house pretending to be Little Red, but when it didn't work, he kicked the door down!!</color>\n" +
                "<color=red>Before the wolf could eat Grandma, a hunter appeared, scaring the wolf and causing him to throw up and faint!</color>";
        }
        else if (intarray.SequenceEqual(new int[] { 2, 1, 2 })) //blue, red, blue
        {
            message = "<color=blue>Little Red Riding Hood got scared by the Big Bad Wolf and ran away.</color>\n" +
                "<color=red>The Wolf then went to Grandma's house pretending to be Little Red, but when it didn't work, he kicked the door down!!</color>\n" +
                "<color=blue>Before the wolf could eat Grandma, a hunter appeared, scaring the wolf and causing him to run away.</color>";
        }
        else if (intarray.SequenceEqual(new int[] { 2, 1, 3 })) //blue, red, yellow
        {
            message = "<color=blue>Little Red Riding Hood got scared by the Big Bad Wolf and ran away.</color>\n" +
                "<color=red>The Wolf then went to Grandma's house pretending to be Little Red, but when it didn't work, he kicked the door down!!</color>\n" +
                "<color=yellow>The Wolf proceeded to enjoy a yummy feast! Guess someone got a happy ending.</color>";
        }
        else if (intarray.SequenceEqual(new int[] { 2, 2, 1 })) //blue, blue, red
        {
            message = "<color=blue>Little Red Riding Hood got scared by the Big Bad Wolf and ran away.</color>\n" +
                "<color=blue>The Wolf then went to Grandma's house pretending to be Little Red, and after she opened the door, he revealed himself as the wolf!</color>\n" +
                "<color=red>Before the wolf could eat Grandma, a hunter appeared, scaring the wolf and causing him to throw up and faint!</color>";
        }
        else if (intarray.SequenceEqual(new int[] { 2, 2, 2 })) //blue, blue, blue
        {
            message = "<color=blue>Little Red Riding Hood got scared by the Big Bad Wolf and ran away.</color>\n" +
                "<color=blue>The Wolf then went to Grandma's house pretending to be Little Red, and after she opened the door, he revealed himself as the wolf!</color>\n" +
                "<color=blue>Before the wolf could eat Grandma, a hunter appeared, scaring the wolf and causing him to run away.</color>";
        }
        else if (intarray.SequenceEqual(new int[] { 2, 2, 3 })) //blue, blue, yellow
        {
            message = "<color=blue>Little Red Riding Hood got scared by the Big Bad Wolf and ran away.</color>\n" +
                "<color=blue>The Wolf then went to Grandma's house pretending to be Little Red, and after she opened the door, he revealed himself as the wolf!</color>\n" +
                "<color=yellow>The Wolf proceeded to enjoy a yummy feast! Guess someone got a happy ending.</color>";
        }
        else
        {
            message = "No story";
        }

        //adds the text to the box
        if (epilogueText != null)
        {
            epilogueText.text = message + "\n<color=black>Press Space to continue</color>";
        }
        else
        {
            Debug.Log(message);
        }
    }

    void Awake()
    {
        if(epilogueText == null)
        {
            CreateRuntimeText();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            SceneManager.LoadScene("Epilogue");
        }
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

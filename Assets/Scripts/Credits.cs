using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class Credits : MonoBehaviour
{
    private float timer = 0f;
    void Start()
    {
        //int state = GameData.selectedColorState;

    }
    void Update()
    {

        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            SceneManager.LoadScene("ArtCapStartScene");
        }
    }
}
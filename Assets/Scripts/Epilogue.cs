using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class Epilogue : MonoBehaviour
{
    void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            SceneManager.LoadScene("Credits");
        }
    }
}

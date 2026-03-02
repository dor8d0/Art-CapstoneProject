using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class RestartScene : MonoBehaviour
{
    public float restartTime = 13f;
    private float timer = 0f;

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= restartTime)
        {
            Scene currentScene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(currentScene.name);
        }

        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            SceneManager.LoadScene("Lil RedHood Scene");
        }
    }
}
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class RestartSceneTwo : MonoBehaviour
{
    public Animator animator;
    private bool hasRestarted = false;

    void Update()
    {
        AnimatorStateInfo state = animator.GetCurrentAnimatorStateInfo(0);

        if (state.IsName("BBW Scene two if blue _ Yellow") && state.normalizedTime >= 1f && !hasRestarted)
        {
            hasRestarted = true;

            Scene currentScene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(currentScene.name);
        }

        if (state.IsName("BBW Scene two if blue _ Blue") && state.normalizedTime >= 1f && !hasRestarted)
        {
            hasRestarted = true;

            Scene currentScene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(currentScene.name);
        }

        if (state.IsName("BBW Scene two if blue _ Red") && state.normalizedTime >= 1f && !hasRestarted)
        {
            hasRestarted = true;

            Scene currentScene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(currentScene.name);
        }

        if (state.IsName("BBW Scene two if blue _ Red") && state.normalizedTime >= 1f && !hasRestarted)
        {
            hasRestarted = true;

            Scene currentScene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(currentScene.name);
        }

        if (state.IsName("BBW Scene two Yellow") && state.normalizedTime >= 1f && !hasRestarted)
        {
            hasRestarted = true;

            Scene currentScene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(currentScene.name);
        }

        if (state.IsName("BBW Scene two Red") && state.normalizedTime >= 1f && !hasRestarted)
        {
            hasRestarted = true;

            Scene currentScene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(currentScene.name);
        }

        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            SceneManager.LoadScene("Lil RedHood Scene");
        }
    }
}
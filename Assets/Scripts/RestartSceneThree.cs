using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class RestartSceneThree : MonoBehaviour
{
    public Animator animator;
    private bool hasRestarted = false;

    void Update()
    {
        AnimatorStateInfo state = animator.GetCurrentAnimatorStateInfo(0);

        if (state.IsName("bbw blue red jump scared and vomite") && state.normalizedTime >= 1f && !hasRestarted)
        {
            hasRestarted = true;

            Scene currentScene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(currentScene.name);
        }

        if (state.IsName("bbw grandma outfit vomit") && state.normalizedTime >= 1f && !hasRestarted)
        {
            hasRestarted = true;

            Scene currentScene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(currentScene.name);
        }

        if (state.IsName("bbw grandma outfit run away") && state.normalizedTime >= 1f && !hasRestarted)
        {
            hasRestarted = true;

            Scene currentScene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(currentScene.name);
        }

        if (state.IsName("BBW RUN AWAY") && state.normalizedTime >= 1f && !hasRestarted)
        {
            hasRestarted = true;

            Scene currentScene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(currentScene.name);
        }

        if (state.IsName("BBW RUN AWAY grandma") && state.normalizedTime >= 1f && !hasRestarted)
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
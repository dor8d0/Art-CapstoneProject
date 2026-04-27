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
            if (GameData.showingFullPlayback == false)
            {
                GameData.showingFullPlayback = true; //restarts the first scene to show full playback
                SceneManager.LoadScene("RedScene");
            }
            else //if the playback is already being shown, loads the epilogue scene
            {
                SceneManager.LoadScene("Epilogue");
            }
        }

        if (state.IsName("bbw grandma outfit vomit") && state.normalizedTime >= 1f && !hasRestarted)
        {
            if (GameData.showingFullPlayback == false)
            {
                GameData.showingFullPlayback = true; //restarts the first scene to show full playback
                SceneManager.LoadScene("RedScene");
            }
            else //if the playback is already being shown, loads the epilogue scene
            {
                SceneManager.LoadScene("Epilogue");
            }
        }

        if (state.IsName("bbw grandma outfit run away") && state.normalizedTime >= 1f && !hasRestarted)
        {
            if (GameData.showingFullPlayback == false)
            {
                GameData.showingFullPlayback = true; //restarts the first scene to show full playback
                SceneManager.LoadScene("RedScene");
            }
            else //if the playback is already being shown, loads the epilogue scene
            {
                SceneManager.LoadScene("Epilogue");
            }
        }

        if (state.IsName("BBW RUN AWAY") && state.normalizedTime >= 1f && !hasRestarted)
        {
            if (GameData.showingFullPlayback == false)
            {
                GameData.showingFullPlayback = true; //restarts the first scene to show full playback
                SceneManager.LoadScene("RedScene");
            }
            else //if the playback is already being shown, loads the epilogue scene
            {
                SceneManager.LoadScene("Epilogue");
            }
        }

        if (state.IsName("BBW RUN AWAY grandma") && state.normalizedTime >= 1f && !hasRestarted)
        {
            if (GameData.showingFullPlayback == false)
            {
                GameData.showingFullPlayback = true; //restarts the first scene to show full playback
                SceneManager.LoadScene("RedScene");
            }
            else //if the playback is already being shown, loads the epilogue scene
            {
                SceneManager.LoadScene("Epilogue");
            }
        }

        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            if (GameData.showingFullPlayback == false)
            {
                GameData.showingFullPlayback = true; //restarts the first scene to show full playback
                SceneManager.LoadScene("RedScene");
            }
            else //if the playback is already being shown, loads the epilogue scene
            {
                SceneManager.LoadScene("Epilogue");
            }
        }
    }
}

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

        if (state.IsName("BBW Scene two if blue _ Yellow") && state.normalizedTime >= 1f && !hasRestarted) //starts the playback and epilogue since this is a route ender
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

        if (state.IsName("BBW Scene two if blue _ Blue") && state.normalizedTime >= 1f && !hasRestarted)
        {
            if (GameData.showingFullPlayback == false)
            {
                SceneManager.LoadScene("Lil RedHood Scene");
            }
            else //if the playback is already being shown, loads the next scene
            {
                SceneManager.LoadScene("Third Scene");
            }
        }

        if (state.IsName("BBW Scene two if blue _ Red") && state.normalizedTime >= 1f && !hasRestarted)
        {
            if (GameData.showingFullPlayback == false)
            {
                SceneManager.LoadScene("Lil RedHood Scene");
            }
            else //if the playback is already being shown, loads the next scene
            {
                SceneManager.LoadScene("Third Scene");
            }
        }

        if (state.IsName("BBW Scene two if blue _ Red") && state.normalizedTime >= 1f && !hasRestarted)
        {
            if (GameData.showingFullPlayback == false)
            {
                SceneManager.LoadScene("Lil RedHood Scene");
            }
            else //if the playback is already being shown, loads the next scene
            {
                SceneManager.LoadScene("Third Scene");
            }
        }

        if (state.IsName("BBW Scene two Yellow") && state.normalizedTime >= 1f && !hasRestarted)
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

        if (state.IsName("BBW Scene two Red") && state.normalizedTime >= 1f && !hasRestarted)
        {
            if (GameData.showingFullPlayback == false)
            {
                SceneManager.LoadScene("Lil RedHood Scene");
            }
            else //if the playback is already being shown, loads the next scene
            {
                SceneManager.LoadScene("Third Scene");
            }
        }

        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            if (GameData.showingFullPlayback == false)
            {
                if (GameData.savedStates[1] == 3) //starts the playback and epilogue if choosing yellow
                {
                    GameData.showingFullPlayback = true;
                    SceneManager.LoadScene("RedScene");
                }
                else
                {
                    SceneManager.LoadScene("Lil RedHood Scene");
                }
            }
            else //if the playback is already being shown, loads the next scene
            {
                if (GameData.savedStates[1] == 3)
                {
                    SceneManager.LoadScene("Epilogue");
                }
                else
                {
                    SceneManager.LoadScene("Third Scene");
                }
            }
        }
    }
}

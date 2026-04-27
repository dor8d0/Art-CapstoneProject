using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class RestartScene : MonoBehaviour
{
    public float redrestartTime = 13f;
    public float bluerestartTime = 13f;
    private float timer = 0f;
    void Start()
    {
        //int state = GameData.selectedColorState;

    }
    void Update()
    {
        timer += Time.deltaTime;
        
        if (timer >= bluerestartTime)
        {
            //will load the epilogue if you reached a route ending
            if (GameData.savedStates[0] == 3)
            {
                SceneManager.LoadScene("Epilouge");
            }
            else if (GameData.showingFullPlayback == true) //if the game is playing back all the scenes
            {
                SceneManager.LoadScene("Second Scene");
            }
            else
            {
                SceneManager.LoadScene("Lil RedHood Scene");
            }
        }


        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            //will load the epilogue if you reached a route ending
            if (GameData.savedStates[0] == 3)
            {
                SceneManager.LoadScene("Epilouge");
            }
            else if (GameData.showingFullPlayback == true) //if the game is playing back all the scenes
            {
                SceneManager.LoadScene("Second Scene");
            }
            else
            {
                SceneManager.LoadScene("Lil RedHood Scene");
            }
            
        }
    }
}
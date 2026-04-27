using UnityEngine;
using UnityEngine.SceneManagement;
public class StartButton : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void GoToNextScene()
    {
        GameData.gameFinished = false;
        GameData.showingFullPlayback = false;
        GameData.savedStates.Clear();
        GameData.savedColors.Clear();
        SceneManager.LoadScene("Lil RedHood Scene");
    }
}

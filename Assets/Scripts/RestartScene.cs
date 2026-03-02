using UnityEngine;
using UnityEngine.SceneManagement;
public class RestartScene : MonoBehaviour
{
    public float restartTime = 13f;
    private float timer = 0f;

    void Start()
    {
        
    }
    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= restartTime)
        {
            Scene BlueScene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(BlueScene.name);
        }
    }

}

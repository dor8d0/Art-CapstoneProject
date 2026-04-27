using UnityEngine;
using UnityEngine.Rendering.Universal;

public class SceneInt : MonoBehaviour
{
    public Light2D spotLight;
    public Animator animatorlilred;

    public Animator animatorbbw;

    void Start()
    {
        int state = GameData.savedStates[0];

        Debug.Log("State from previous scene: " + state);

        if (spotLight != null)
        {
        spotLight.color = GameData.savedColors[0];
        spotLight.intensity = GameData.selectedIntensity;
        Debug.Log("Light Color =" + spotLight.color + ", intensity=" + spotLight.intensity);
        }
        
        if (animatorlilred != null)
        {
        animatorlilred.SetInteger("state", state); 
        Debug.Log("animatorlilred set to: " + state);
        }

        if (animatorbbw != null)
        {
        animatorbbw.SetInteger("state", state); 
        Debug.Log("animatorbbw set to: " + state);
        }
    }
}
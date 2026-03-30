using UnityEngine;
using UnityEngine.Rendering.Universal;

public class SceneInt : MonoBehaviour
{
    public Light2D spotLight;
    public Animator animatorlilred;

    public Animator animatorbbw;

    void Start()
    {
        int state = GameData.selectedColorState;

        Debug.Log("State from previous scene: " + state);

        if (spotLight != null)
        {
        spotLight.color = GameData.selectedColor;
        spotLight.intensity = GameData.selectedIntensity;
        Debug.Log("Restored light: color=" + spotLight.color + ", intensity=" + spotLight.intensity);
        }
        
        if (animatorlilred != null)
        {
        animatorlilred.SetInteger("state", state); 
        Debug.Log("animatorlilred parameter set to: " + state);
        }

        if (animatorbbw != null)
        {
        animatorbbw.SetInteger("state", state); 
        Debug.Log("animatorbbw parameter set to: " + state);
        }
    }
}
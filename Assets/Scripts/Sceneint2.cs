using UnityEngine;
using UnityEngine.Rendering.Universal;

public class Sceneint2 : MonoBehaviour
{
    public Light2D spotLight;
    public Animator animatorgrandma;
    public Animator animatordoor;
    public Animator animatorbbw;
    public int sceneOneState;
    void Start()
    {
        int state = GameData.selectedColorState;

        if (GameData.savedStates.Count > 0)
        {
            //sceneOneState = 1;
            sceneOneState = GameData.savedStates[0];
        }
        else
        {
            Debug.LogWarning("No saved states found!");
            sceneOneState = 0;
        }
        
        Debug.Log("Scene One State: " + sceneOneState);
        Debug.Log("Current State: " + state);

        if (spotLight != null)
        {
            spotLight.color = GameData.selectedColor;
            spotLight.intensity = GameData.selectedIntensity;
        }
        
        if (animatorgrandma != null)
        {
            animatorgrandma.SetInteger("state", state);
            animatorgrandma.SetInteger("stateone", sceneOneState);
        }

        if (animatordoor != null)
        {
            animatordoor.SetInteger("state", state);
            animatordoor.SetInteger("stateone", sceneOneState);
        }

        if (animatorbbw != null)
        {
            animatorbbw.SetInteger("state", state);
            animatorbbw.SetInteger("stateone", sceneOneState);
        }
    }
}
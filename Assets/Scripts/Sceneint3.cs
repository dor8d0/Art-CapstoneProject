using System.Data;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class Sceneint3 : MonoBehaviour
{
    public Light2D spotLight;
    public Animator animatorgrandma;
    public Animator animatorball;
    public Animator animatorlilred;
    public Animator animatorhunter;
    public Animator animatorbbw;
    public int sceneOneState;
    public SpriteRenderer sprite;
    public SpriteRenderer ball;
    public GameObject ballform, turkeyone, turkeytwo, turkeythree, grandmaoh;
    void Start()
    {
        int state = GameData.savedStates[2];
        ballform.SetActive(false);
        turkeyone.SetActive(false);
        turkeytwo.SetActive(false);
        turkeythree.SetActive(false);
        grandmaoh.SetActive(false);

        if (GameData.savedStates.Count > 0)
        {
            //sceneOneState = 2;
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
            spotLight.color = GameData.savedColors[2];
            spotLight.intensity = GameData.selectedIntensity;
        }
        
        //if (animatorgrandma != null)
        //{
            //animatorgrandma.SetInteger("state", state);
            //animatorgrandma.SetInteger("stateone", sceneOneState);
       // }

        if (animatorball != null)
        {
            animatorball.SetInteger("state", state);
            animatorball.SetInteger("stateone", sceneOneState);
        }

        if (animatorbbw != null)
        {
            animatorbbw.SetInteger("state", state);
            animatorbbw.SetInteger("stateone", sceneOneState);
        }

        if (animatorhunter != null)
        {
            animatorhunter.SetInteger("state", state);
            animatorhunter.SetInteger("stateone", sceneOneState);
        }

        if (animatorlilred != null)
        {
            animatorlilred.SetInteger("state", state);
            animatorlilred.SetInteger("stateone", sceneOneState);
        }

        Debug.Log("=== Scene 3 Data ===");

for (int i = 0; i < GameData.savedStates.Count; i++)
{
    Debug.Log("Index " + i + ": " + GameData.savedStates[i]);
}
    }

   
    void Update()
    {
        AnimatorStateInfo bbwState = animatorbbw.GetCurrentAnimatorStateInfo(0);

        bool showBall =
            bbwState.IsName("bbw grandma outfit vomit") ||
            bbwState.IsName("bbw blue red jump scared and vomite");

        bool showturkeys =
            bbwState.IsName("Happy meals");

        if (showBall)
        {
            ballform.SetActive(true);
        }

        if (showturkeys)
        {
            turkeyone.SetActive(true);
        turkeytwo.SetActive(true);
        turkeythree.SetActive(true);
        }

        if(sceneOneState == 2 && !showturkeys)
        {
         grandmaoh.SetActive(true);
        }
    }
}

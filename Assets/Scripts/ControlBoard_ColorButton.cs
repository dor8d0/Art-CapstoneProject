using UnityEngine;
using UnityEngine.Rendering.Universal;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ControlBoard_ColorButton : MonoBehaviour
{

    [Header("Spotlight")]
    public Light2D spotLight; //the spotlight that will have its color changed

    [Header("Button Color")]
    public Color buttonColor; //the color that this button will change the spotlight to

    private int state = 0; 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //finds references for the spotlight and other objects
        if(spotLight == null)
        {
            spotLight = GameObject.Find("Spot Light 2D")?.GetComponent<Light2D>();
        }
    }

    //changes the spotlight to be the button's color and updates the recorded color in the code
    public void changeSpotlightColor()
    {
        spotLight.color = buttonColor;
        if (spotLight == null) return;

        // Cycle through states: 0 -> 1 -> 2 -> 0
        state = (state + 1) % 4;
        Debug.Log("Current State Integer: " + state);

        switch (state)
        {
            case 0: // OFF
                spotLight.color = Color.black;
                spotLight.intensity = 0f;
               // if(confirmButtonText != null) confirmButtonText.text = "Select Color";
                break;
            case 1: // Button Color
                spotLight.color = buttonColor;
                //if(confirmButtonText != null) confirmButtonText.text = "Confirm Red";
                break;
        }
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

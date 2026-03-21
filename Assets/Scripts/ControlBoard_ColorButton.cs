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
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
